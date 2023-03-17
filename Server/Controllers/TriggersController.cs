using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeccaUI_THDxIOT.Server.Data;
using MeccaUI_THDxIOT.Shared.Models;

namespace MeccaUI_THDxIOT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TriggersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TriggersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Triggers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trigger>>> GetTriggers()
        {
            return await _context.Triggers
                                    .Include(t => t.TriggersReactions)
                                        .ThenInclude(tr => tr.Reaction)
                                            .ToListAsync();
        }

        // GET: api/Triggers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trigger>> GetTrigger(long id)
        {
            var trigger = await _context.Triggers
                                        .Where(t=>t.TriggerID == id)
                                            .Include(t => t.TriggersReactions)
                                                .ThenInclude(tr => tr.Reaction)
                                                    .FirstOrDefaultAsync();
                                

            if (trigger == null)
            {
                return NotFound();
            }

            return trigger;
        }

        // PUT: api/Triggers/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrigger(long id, Trigger trigger)
        {
            if (id != trigger.TriggerID)
            {
                return BadRequest();
            }

            _context.Entry(trigger).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TriggerExists(id))
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

        // POST: api/Triggers
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Trigger>> PostTrigger(Trigger trigger)
        {
            _context.Triggers.Add(trigger);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTrigger", new { id = trigger.TriggerID }, trigger);
        }

        // DELETE: api/Triggers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Trigger>> DeleteTrigger(long id)
        {
            var trigger = await _context.Triggers.FindAsync(id);
            if (trigger == null)
            {
                return NotFound();
            }

            _context.Triggers.Remove(trigger);
            await _context.SaveChangesAsync();

            return trigger;
        }

        private bool TriggerExists(long id)
        {
            return _context.Triggers.Any(e => e.TriggerID == id);
        }
    }
}
