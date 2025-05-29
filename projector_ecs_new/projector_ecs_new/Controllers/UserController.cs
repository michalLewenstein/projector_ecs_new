//using AutoMapper;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Mvc;
//using projector_ecs_new.Core.Dto;
//using projector_ecs_new.Core.Models;
//using projector_ecs_new.Core.Service;
//using projector_ecs_new.Models;
//using System.Security.Claims;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace projector_ecs_new.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {
//        private readonly IUserService _userService;
//        private readonly IMapper _mapper;
//        public UserController(IUserService userService, IMapper mapper)
//        {
//            _userService = userService;
//            _mapper = mapper;
//        }

//        // GET: api/<UserController>
//        [HttpGet]
//        public ActionResult GetAllUsers()
//        {
//            return Ok(_userService.getAllUsers());
//        }


//        // GET api/<UserController>/5
//        [HttpGet("{id}")]
//        public IEnumerable<string> Get(int id)
//        {
//            return new string[] { "value1", "value2" };
//        }

//        // POST api/<UserController>
//        //[HttpPost]
//        //public IActionResult SignUp([FromBody] User user)
//        //{
//        //    try
//        //    {
//        //        _userService.SignUp(user);
//        //        return Ok(new { message = "user registered successfully" });
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        Console.WriteLine($"Error: {ex.Message}");
//        //        if (ex.Message == "user already exists!")
//        //        {
//        //            return Conflict(new { error = "user already exists!" });
//        //        }
//        //        return BadRequest(new { error = ex.Message });
//        //    }
//        //}
//        // POST api/<UserController>
//        [HttpPost("login")]
//        public IActionResult LogIn([FromBody] DTOUserLogin user)
//        {
//            try
//            {
//                var userToLogin = _mapper.Map<AuthRequestContact>(user);
//                var existingUser = _userService.LogIn(userToLogin.Email);

//                if (existingUser == null)
//                {
//                    return Unauthorized(new { error = "Invalid credentials" });
//                }

//                // שלב חדש - שמירת עוגייה עם ה־UserId
//                Response.Cookies.Append("UserId", existingUser.Id.ToString(), new CookieOptions
//                {
//                    HttpOnly = true,
//                    Secure = true, // אם את לא משתמשת ב-HTTPS, בזמן הפיתוח אפשר להוריד ל-false
//                    SameSite = SameSiteMode.None, // אם את שולחת קריאות מ־localhost:4200 ל־7133
//                });

//                return Ok(new { message = "user login successfully" });
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(new { error = ex.Message });
//            }
//        }


//        [HttpGet("getLoggedInUserId")]
//        public IActionResult GetLoggedInUserId()
//        {
//            var userIdClaim = User.FindFirst("UserId")?.Value;
//            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
//                return Unauthorized(new { message = "User is not logged in." });

//            return Ok(new { userId = userId });
//        }

//        [HttpPost("logout")]
//        public IActionResult Logout()
//        {
//            Response.Cookies.Delete("UserId");

//            return Ok(new { message = "התנתקת בהצלחה" });
//        }


//        // PUT api/<UserController>/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] string value)
//        {
//        }

//        // DELETE api/<UserController>/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using projector_ecs_new.Core.Dto;
using projector_ecs_new.Core.Models;
using projector_ecs_new.Core.Service;
using projector_ecs_new.Models;

namespace projector_ecs_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        // שם העוגייה לזיהוי משתמש
        private const string UserIdCookieName = "UserId";
        // שם העוגייה לטוקן JWT (תואם לשם בבקר Auth)
        //private const string JwtCookieName = "jwt";

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        // GET: api/<UserController>
        [HttpGet]
        public ActionResult GetAllUsers()
        {
            return Ok(_userService.getAllUsers());
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "value1", "value2" };
        }
        // POST api/<UserController>
        //[HttpPost]
        //public IActionResult SignUp([FromBody] User user)
        //{
        //    try
        //    {
        //        _userService.SignUp(user);
        //        return Ok(new { message = "user registered successfully" });
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}");
        //        if (ex.Message == "user already exists!")
        //        {
        //            return Conflict(new { error = "user already exists!" });
        //        }
        //        return BadRequest(new { error = ex.Message });
        //    }
        //}
        // POST api/<UserController>
        [HttpPost("login")]
        public IActionResult LogIn([FromBody] DTOUserLogin user)
        {
            try
            {
                var userToLogin = _mapper.Map<AuthRequestContact>(user);
                var existingUser = _userService.LogIn(userToLogin.Email);

                if (existingUser == null)
                {
                    return Unauthorized(new { error = "Invalid credentials" });
                }

                //שלב חדש -שמירת עוגייה עם ה־UserId
                Response.Cookies.Append("UserId", existingUser.Id.ToString(), new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true, // אם את לא משתמשת ב-HTTPS, בזמן הפיתוח אפשר להוריד ל-false
                    SameSite = SameSiteMode.None, // אם את שולחת קריאות מ־localhost:4200 ל־7133
                });

                return Ok(new { message = "user login successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("getLoggedInUserId")]
        public Boolean GetLoggedInUserId()
        {
            var userIdClaim = User.FindFirst("UserId")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
            {
                return false;
            }

            return  true;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // פונקציה פנימית לשמירת מזהה משתמש בעוגייה
        private void SetUserIdCookie(int userId)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Secure = true,  // שנה ל-false בסביבת פיתוח אם אין לך HTTPS
                SameSite = SameSiteMode.None,
                Expires = DateTime.UtcNow.AddMinutes(15) 
            };

            Response.Cookies.Append(UserIdCookieName, userId.ToString(), cookieOptions);
        }

       
    }
}