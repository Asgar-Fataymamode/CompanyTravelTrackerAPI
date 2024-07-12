using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompanyTravelTrackerAPI.Data;
using CompanyTravelTrackerAPI.Models;

namespace CompanyTravelTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForthcomingVisitorsController : ControllerBase
    {
        private readonly CompanyTravelTrackerContext _context;

        public ForthcomingVisitorsController(CompanyTravelTrackerContext context)
        {
            _context = context;
        }

        // GET: api/ForthcomingVisitors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ForthcomingVisitor>>> GetForthcomingVisitors()
        {
            return await _context.ForthcomingVisitors.ToListAsync();
        }

        // GET: api/ForthcomingVisitors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ForthcomingVisitor>> GetForthcomingVisitor(int id)
        {
            var visitor = await _context.ForthcomingVisitors.FindAsync(id);

            if (visitor == null)
            {
                return NotFound();
            }

            return visitor;
        }

        // POST: api/ForthcomingVisitors
        [HttpPost]
        public async Task<ActionResult<ForthcomingVisitor>> PostForthcomingVisitor(ForthcomingVisitor visitor)
        {
            _context.ForthcomingVisitors.Add(visitor);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetForthcomingVisitor), new { id = visitor.Id }, visitor);
        }

        // PUT: api/ForthcomingVisitors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutForthcomingVisitor(int id, ForthcomingVisitor visitor)
        {
            if (id != visitor.Id)
            {
                return BadRequest();
            }

            _context.Entry(visitor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ForthcomingVisitorExists(id))
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

        // DELETE: api/ForthcomingVisitors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteForthcomingVisitor(int id)
        {
            var visitor = await _context.ForthcomingVisitors.FindAsync(id);
            if (visitor == null)
            {
                return NotFound();
            }

            _context.ForthcomingVisitors.Remove(visitor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ForthcomingVisitorExists(int id)
        {
            return _context.ForthcomingVisitors.Any(e => e.Id == id);
        }
    }
}
