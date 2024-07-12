using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CompanyTravelTrackerAPI.Data;
using CompanyTravelTrackerAPI.Models;

namespace CompanyTravelTrackerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OutgoingVisitorsController : ControllerBase
    {
        private readonly CompanyTravelTrackerContext _context;

        public OutgoingVisitorsController(CompanyTravelTrackerContext context)
        {
            _context = context;
        }

        // GET: api/OutgoingVisitors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OutgoingVisitor>>> GetOutgoingVisitors()
        {
            return await _context.OutgoingVisitors.ToListAsync();
        }

        // GET: api/OutgoingVisitors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OutgoingVisitor>> GetOutgoingVisitor(int id)
        {
            var visitor = await _context.OutgoingVisitors.FindAsync(id);

            if (visitor == null)
            {
                return NotFound();
            }

            return visitor;
        }

        // POST: api/OutgoingVisitors
        [HttpPost]
        public async Task<ActionResult<OutgoingVisitor>> PostOutgoingVisitor(OutgoingVisitor visitor)
        {
            _context.OutgoingVisitors.Add(visitor);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOutgoingVisitor), new { id = visitor.Id }, visitor);
        }

        // PUT: api/OutgoingVisitors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOutgoingVisitor(int id, OutgoingVisitor visitor)
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
                if (!OutgoingVisitorExists(id))
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

        // DELETE: api/OutgoingVisitors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOutgoingVisitor(int id)
        {
            var visitor = await _context.OutgoingVisitors.FindAsync(id);
            if (visitor == null)
            {
                return NotFound();
            }

            _context.OutgoingVisitors.Remove(visitor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OutgoingVisitorExists(int id)
        {
            return _context.OutgoingVisitors.Any(e => e.Id == id);
        }
    }
}
