using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeccaUI_THDxIOT.Server.Data;
using MeccaUI_THDxIOT.Shared.Models;

namespace MeccaUI_THDxIOT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReactionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Reactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Reaction>>> GetReactions()
        {
            return await _context.Reactions
                                    .Include(r => r.ReactionSteps)
                                       .ThenInclude(rs => rs.Movement)
                                    .Include(t => t.TriggersReactions)
                                    //.ThenInclude(tr => tr.Trigger)
                                    .ToListAsync();

        }
        // GET: api/Reactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Reaction>> GetReaction(long id)
        {
            var reaction = await _context.Reactions
                                    .Where(t => t.ReactionID == id)
                                        .Include(r => r.ReactionSteps)
                                        .ThenInclude(rs => rs.Movement)
                                        .Where(rs => rs.ReactionID == id)
                                        .Include(r => r.TriggersReactions)
                                        .ThenInclude(tr => tr.Trigger)
                                        .FirstOrDefaultAsync();

            if (reaction == null)
            {
                return NotFound();
            }

            return reaction;
        }

        // PUT: api/Reactions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReaction(long id, Reaction reaction)
        {
            if (id != reaction.ReactionID)
            {
                return BadRequest();
            }

            _context.Entry(reaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReactionExists(id))
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

        // POST: api/Reactions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Reaction>> PostReaction(Reaction reaction)
        {
            _context.Reactions.Add(reaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReaction", new { id = reaction.ReactionID }, reaction);
        }

        // DELETE: api/Reactions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Reaction>> DeleteReaction(long id)
        {
            var reaction = await _context.Reactions.FindAsync(id);
            if (reaction == null)
            {
                return NotFound();
            }

            _context.Reactions.Remove(reaction);
            await _context.SaveChangesAsync();

            return reaction;
        }

        private bool ReactionExists(long id)
        {
            return _context.Reactions.Any(e => e.ReactionID == id);
        }
    }
}
