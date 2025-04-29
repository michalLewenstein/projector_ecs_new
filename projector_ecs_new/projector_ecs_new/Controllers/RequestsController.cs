using Microsoft.AspNetCore.Mvc;
using projector_ecs_new.Core.Service;
using projector_ecs_new.Service;

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
        public ActionResult Get()
        {
            return Ok(_requestService.getAllRequests());
        }

        // GET api/<RequestsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
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
