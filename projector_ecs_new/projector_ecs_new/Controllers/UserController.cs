using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using projector_ecs_new.Core.Models;
using projector_ecs_new.Core.Service;
using projector_ecs_new.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projector_ecs_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
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
        [HttpPost]
        public IActionResult SignUp([FromBody] User user)
        {
            try
            {
                _userService.SignUp(user);
                return Ok(new { message = "user registered successfully" });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (ex.Message == "user already exists!")
                {
                    return Conflict(new { error = "user already exists!" });
                }
                return BadRequest(new { error = ex.Message });
            }
        }
        // POST api/<UserController>
        [HttpPost("login")]
        public  IActionResult LogIn([FromBody] UserLogin user)
        {
            try
            {
                _userService.LogIn(_mapper.Map<User>(user));
                return Ok(new { message = "user login successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
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
    }
}
