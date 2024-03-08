using grpc.client.Models;
using grpc.client.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace grpc.client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personServce;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PersonsController(IPersonService personService, IHttpContextAccessor httpContextAccessor) 
        {
            _personServce = personService;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public async Task<ActionResult<List<Person>>> GetPersonPaginatedAsync([FromQuery] int page, [FromQuery] int limit)
        {
            CancellationToken cancellationToken =  _httpContextAccessor.HttpContext.RequestAborted;

            List<Person> people = await _personServce.GetPersonPaginatedAsync(page, limit, cancellationToken);

            return Ok(people);
        }

        [HttpPost]
        public async Task<IActionResult> AddPersonAsync([FromBody] AddPersonDto dto)
        {
            CancellationToken cancellationToken = _httpContextAccessor.HttpContext.RequestAborted;

            await _personServce.AddPersonAsync(dto.Name, dto.Age, cancellationToken);

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
