using Crawler.Ndb.Integration.ApiService.Models.Database;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Crawler.Ndb.Integration.ApiService.Services.Database
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatabaseController : ControllerBase
    {
        // GET: api/<DatabaseController>
        [HttpGet]
        public IEnumerable<DatabaseDetail> Get()
        {
            return new List<DatabaseDetail>
            {
                new DatabaseDetail { /* Initialize properties here */ },
                new DatabaseDetail { /* Initialize properties here */ }
            };
        }

        // GET api/<DatabaseController>/5
        [HttpGet("{id}")]
        public DatabaseDetail Get(DatabaseGet id)
        {
            return new DatabaseDetail { /* Initialize properties here based on id */ };
        }

        // POST api/<DatabaseController>
        [HttpPost]
        public void Post([FromBody] DatabaseCreate value)
        {
        }

        // PUT api/<DatabaseController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] DatabaseUpdate value)
        {
        }

        // DELETE api/<DatabaseController>/5
        [HttpDelete("{id}")]
        public void Delete(DatabaseDelete id)
        {
        }
    }
}
