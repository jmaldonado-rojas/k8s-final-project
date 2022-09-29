using Microsoft.AspNetCore.Mvc;
using MyWebApi.Data;
using MyWebApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        // GET: api/<PersonController>
        [HttpGet]
        public async Task<IActionResult> GetAllPersons()
        {
            return Ok(await _personRepository.GetAllPersons());
        }

        // GET api/<PersonController>/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPerson(int id)
        {
            return Ok(await _personRepository.GetPerson(id));
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<IActionResult> AddPerson([FromBody] Person person)
        {
            if (person == null || string.IsNullOrEmpty(person.Name) ||
                string.IsNullOrEmpty(person.LastName) || string.IsNullOrEmpty(person.Role))
            {
                return BadRequest("Invalid body or missing fields.");
            }
            
            var personCreated = await _personRepository.AddPerson(person);
            return Created("created", personCreated);
        }
    }
}
