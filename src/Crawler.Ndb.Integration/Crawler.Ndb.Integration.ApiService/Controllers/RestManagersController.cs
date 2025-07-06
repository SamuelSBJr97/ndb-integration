using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Crawler.Ndb.Integration.ApiService.Data;
using Crawler.Ndb.Integration.Web.Domain.RestManager.Model;

namespace Crawler.Ndb.Integration.ApiService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestManagersController : ControllerBase
    {
        private readonly CrawlerNdbIntegrationApiServiceContext _context;

        public RestManagersController(CrawlerNdbIntegrationApiServiceContext context)
        {
            _context = context;
        }

        // GET: api/RestManagers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RestManager>>> GetRestManager()
        {
            return await _context.RestManager.ToListAsync();
        }

        // GET: api/RestManagers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RestManager>> GetRestManager(Guid id)
        {
            var restManager = await _context.RestManager.FindAsync(id);

            if (restManager == null)
            {
                return NotFound();
            }

            return restManager;
        }

        // PUT: api/RestManagers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRestManager(Guid id, RestManager restManager)
        {
            if (id != restManager.Id)
            {
                return BadRequest();
            }

            _context.Entry(restManager).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RestManagerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RestManagers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RestManager>> PostRestManager(RestManager restManager)
        {
            _context.RestManager.Add(restManager);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRestManager", new { id = restManager.Id }, restManager);
        }

        // DELETE: api/RestManagers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRestManager(Guid id)
        {
            var restManager = await _context.RestManager.FindAsync(id);
            if (restManager == null)
            {
                return NotFound();
            }

            _context.RestManager.Remove(restManager);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RestManagerExists(Guid id)
        {
            return _context.RestManager.Any(e => e.Id == id);
        }
    }
}
