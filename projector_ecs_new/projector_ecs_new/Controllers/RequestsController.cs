using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using projector_ecs_new.Core.Dto;
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
        private readonly IMapper _mapper;
        public RequestsController(IRequestService requestService, IMapper mapper)
        {
            this._requestService = requestService;
            this._mapper = mapper;
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
            var requests = _requestService.GetRequestsByPage(userId, page, pageSize);
            return Ok(_mapper.Map<List<DTORequest>>(requests)); 
        }

        // GET api/<RequestsController>/5
        [HttpGet("search")]
        public IActionResult SearchAuthRequests([FromQuery] int? number,
                                                [FromQuery] string? street,
                                                [FromQuery] int? statusId,
                                                [FromQuery] int page)
        {
            var userIdClaim = User.FindFirst("UserId")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
                return Unauthorized("User ID is missing in token");

            int pageSize = 25;
            var requests = _requestService.SearchAuthRequests(number, street, statusId, userId, page, pageSize);
            return Ok(_mapper.Map<List<DTORequest>>(requests));
        }
        // GET api/<RequestsController>/5
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetRequestDetailsById(int id)
        {
            var userIdClaim = User.FindFirst("UserId")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
                return Unauthorized("User ID is missing in token");
            var request = _requestService.GetRequestDetailsById(id);
            if (request == null)
                return NotFound($"Request with ID {id} not found.");

            var workTypes = _requestService.GetWorkTypes();
            return Ok(new DTORequestWithWorkTypes
            {
                Request = request,
                WorkTypes = workTypes
            });
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
