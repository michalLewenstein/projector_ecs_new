﻿using AutoMapper;
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
        private readonly IEmailService _emailService;
        public RequestsController(IRequestService requestService, IMapper mapper, IEmailService emailService)
        {
            this._requestService = requestService;
            this._mapper = mapper;
            _emailService = emailService;
        }
        // GET: api/<RequestsController>
        [HttpGet]
        public ActionResult GetRequestsByPage([FromQuery] int page)
        {

            var userIdClaim = User.FindFirst("UserId")?.Value;
            if (string.IsNullOrEmpty(userIdClaim) || !int.TryParse(userIdClaim, out int userId))
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

            var request = _requestService.GetRequestDetailsById(id, userId);
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
        //[HttpPost]
        //public bool AddMessage([FromQuery] string idAuthRequest, [FromQuery] string userId, [FromQuery] string userType,
        //                                [FromQuery] string userFullname, [FromQuery] string userAuthorityName,
        //                                [FromQuery] string idMsgType, [FromQuery] string msgContent, [FromQuery] string notifyContacts)
        //{
        //    return _requestService.AddMessage(idAuthRequest, userId, userType,
        //                                 userFullname, userAuthorityName,
        //                                 idMsgType, msgContent, notifyContacts);
        //}

        [HttpPost("email")]
        public IActionResult SendTestEmail()
        {
            try
            {
                var code = new Random().Next(100000, 999999);
                string to = "3230290@gmail.com";
                string subject = "קוד אישור";
                string body = $"הקוד שלך הוא: {code}";

                _emailService.SendEmail(to, subject, body);

                return Ok("המייל נשלח");
            }
            catch (Exception ex)
            {
                return BadRequest("שליחת המייל נכשלה: " + ex.Message);
            }
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
