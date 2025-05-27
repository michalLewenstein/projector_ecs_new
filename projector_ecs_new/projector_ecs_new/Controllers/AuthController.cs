//using Microsoft.AspNetCore.Mvc;
//using Microsoft.IdentityModel.Tokens;
//using Org.BouncyCastle.Crypto.Generators;
//using projector_ecs_new.Core.Service;
//using projector_ecs_new.Models;
//using System.IdentityModel.Tokens.Jwt;
//using System.Security.Claims;
//using System.Text;


//namespace projector_ecs_new.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AuthController : ControllerBase
//    {
//        private readonly IConfiguration _configuration;
//        private readonly IUserService _userService;
//        public AuthController(IConfiguration configuration, IUserService userService)
//        {
//            _configuration = configuration;
//            _userService = userService;
//        }
//        // POST api/<AuthController>
//        [HttpPost]
//        public IActionResult Login([FromBody] DTOUserLogin userLogin)
//        {
//            var findUser = _userService.LogIn(userLogin.Email);
//            if (findUser == null)
//            {
//                return NotFound(new { message = "User not found" });
//            }
//            //else if (!BCrypt.Net.BCrypt.Verify(userLogin.CodeKey, findUser.CodeKey))
//            else if(findUser.CodeKey!=userLogin.CodeKey)
//            {
//                return Unauthorized(new { message = "Incorrect password" });
//            }
//            //var roles = findUser.UserRoles?.Select(ur => ur.Role.Name).ToList() ?? new List<string>();
//            var claims = new List<Claim>()
//        {
//            new Claim(ClaimTypes.Name, findUser.Email),
//            new Claim("UserId", findUser.Id.ToString()),
//            //new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", string.Join(",", roles))
//    };

//            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWT:Key")));
//            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

//            var tokenOptions = new JwtSecurityToken(
//                issuer: _configuration.GetValue<string>("JWT:Issuer"),
//                audience: _configuration.GetValue<string>("JWT:Audience"),
//                claims: claims,
//                expires: DateTime.Now.AddMinutes(1440),
//                signingCredentials: signinCredentials
//            );
//            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
//            var cookieOptions = new CookieOptions
//            {
//                HttpOnly = true,
//                Secure = false,
//                SameSite = SameSiteMode.None,
//                Expires = DateTime.UtcNow.AddMinutes(1440)
//            };
//            Response.Cookies.Append("jwt", tokenString, cookieOptions);
//            return Ok(new { findUser.Id, Token = tokenString });
//        }
//        // DELETE api/<AuthController>
//        [HttpPost("logout")]
//        public IActionResult Logout()
//        {
//            if (Request.Cookies["jwt"] != null)
//            {
//                Response.Cookies.Delete("jwt");
//                return Ok(new { message = "התנתקות בוצעה בהצלחה" });
//            }
//            return BadRequest(new { message = "המשתמש כבר מנותק" });
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using projector_ecs_new.Core.Service;
using projector_ecs_new.Models;

namespace projector_ecs_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        // השם של העוגייה שבה נשמור את ה-JWT
        private const string JwtCookieName = "jwt";

        public AuthController(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }

        // POST api/<AuthController>
        [HttpPost]
        public IActionResult Login([FromBody] DTOUserLogin userLogin)
        {
            try
            {
                var findUser = _userService.LogIn(userLogin.Email);

                if (findUser == null)
                {
                    return NotFound(new { message = "User not found" });
                }
                else if (findUser.CodeKey != userLogin.CodeKey)
                {
                    return Unauthorized(new { message = "Incorrect password" });
                }

                // יצירת טוקן JWT
                var tokenString = CreateJwtToken(findUser.Email, findUser.Id);

                // שמירת הטוקן בעוגייה
                AddJwtCookie(tokenString);

                return Ok(new { findUser.Id, Token = tokenString });
            }
            catch (Exception ex)
            {
                // החזרת שגיאה כללית ללקוח
                return StatusCode(500, new { message = "An error occurred: " + ex.Message });
            }
        }

        // POST api/<AuthController>/refresh-token
        [HttpPost("refresh-token")]
        public IActionResult RefreshToken()
        {
            // בדיקה האם יש טוקן קיים
            if (!Request.Cookies.TryGetValue(JwtCookieName, out var existingToken))
            {
                return Unauthorized(new { message = "No active session found" });
            }

            try
            {
                // פיענוח הטוקן הקיים
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWT:Key"));
                var validationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = true,
                    ValidIssuer = _configuration.GetValue<string>("JWT:Issuer"),
                    ValidateAudience = true,
                    ValidAudience = _configuration.GetValue<string>("JWT:Audience"),
                    ClockSkew = TimeSpan.Zero
                };

                var principal = tokenHandler.ValidateToken(existingToken, validationParameters, out var validatedToken);

                // וידוא שסוג הטוקן הוא JWT
                if (validatedToken is not JwtSecurityToken jwtToken ||
                    !jwtToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256, StringComparison.InvariantCultureIgnoreCase))
                {
                    return Unauthorized(new { message = "Invalid token format" });
                }

                // חילוץ המידע מהטוקן הקיים
                var userId = principal.FindFirst("UserId")?.Value;
                var userEmail = principal.FindFirst(ClaimTypes.Name)?.Value;

                if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userEmail))
                {
                    return Unauthorized(new { message = "Invalid token claims" });
                }

                // יצירת טוקן חדש
                var newTokenString = CreateJwtToken(userEmail, int.Parse(userId));

                // עדכון העוגייה עם הטוקן החדש
                AddJwtCookie(newTokenString);

                return Ok(new { message = "Session extended successfully" });
            }
            catch (SecurityTokenException)
            {
                // במקרה של טוקן לא תקף, נמחק את העוגייה ונחזיר שגיאה
                Response.Cookies.Delete(JwtCookieName);
                return Unauthorized(new { message = "Invalid or expired token" });
            }
        }

        // POST api/<AuthController>/logout
        [HttpPost("logout")]
        public IActionResult Logout()
        {
            if (Request.Cookies[JwtCookieName] != null)
            {
                // מחיקת העוגייה מהשרת
                Response.Cookies.Delete(JwtCookieName, new CookieOptions
                {
                    // חשוב - צריך להשתמש באותן הגדרות של העוגייה המקורית כדי שהמחיקה תעבוד
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.None
                });

                return Ok(new { message = "התנתקות בוצעה בהצלחה" });
            }

            return BadRequest(new { message = "המשתמש כבר מנותק" });
        }

        // פונקציה פנימית ליצירת טוקן JWT
        private string CreateJwtToken(string userEmail, int userId)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, userEmail),
                new Claim("UserId", userId.ToString())
            };

            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWT:Key")));
            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            var tokenOptions = new JwtSecurityToken(
                issuer: _configuration.GetValue<string>("JWT:Issuer"),
                audience: _configuration.GetValue<string>("JWT:Audience"),
                claims: claims,
                expires: DateTime.Now.AddMinutes(1440), 
                signingCredentials: signinCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(tokenOptions);
        }

        // פונקציה פנימית להוספת עוגיית JWT
        private void AddJwtCookie(string tokenString)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true, // מונע גישה לעוגייה באמצעות JavaScript
                Secure = true,   // דורש HTTPS (שנה ל-false בסביבת פיתוח אם אין לך HTTPS)
                SameSite = SameSiteMode.None, // מאפשר לשלוח את העוגייה בבקשות Cross-Origin
                Expires = DateTime.UtcNow.AddMinutes(1440) // 24 שעות
            };

            Response.Cookies.Append(JwtCookieName, tokenString, cookieOptions);
        }
    }
}
