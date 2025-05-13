using Microsoft.AspNetCore.Mvc;
using projector_ecs_new.Core.Models;
using projector_ecs_new.Core.Service;
using projector_ecs_new.Service;
using System.IO;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace projector_ecs_new.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestsController : ControllerBase
    {
        private readonly IRequestService _requestService;
        public RequestsController(IRequestService requestService)
        {
            this._requestService = requestService;
        }
        // GET: api/<RequestsController>
        [HttpGet]
        public ActionResult GetRequestsByPage([FromQuery] int page)
        {
            if (!Request.Cookies.TryGetValue("UserId", out string? userIdString) || !int.TryParse(userIdString, out int userId))
            {
                return Unauthorized("User not logged in");
            }
            int pageSize = 25;
            return Ok(_requestService.GetRequestsByPage(userId, page, pageSize));
        }

        // GET api/<RequestsController>/5
        [HttpGet("search")]
        public IActionResult SearchAuthRequests([FromQuery] int? number,
                                                [FromQuery] string? street,
                                                [FromQuery] int? statusId,
                                                [FromQuery] int page)
        {
            if (!Request.Cookies.TryGetValue("UserId", out string? userIdString) || !int.TryParse(userIdString, out int userId))
            {
                return Unauthorized("User not logged in");
            }

            int pageSize = 25;
            return Ok(_requestService.SearchAuthRequests(number, street, statusId, userId, page, pageSize));
        }

        // POST api/<RequestsController>
        [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<RequestsController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<RequestsController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}
