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
    public class TriggersReactionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TriggersReactionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TriggersReactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TriggersReactions>>> GettriggersReactions()
        {
            return await _context.triggersReactions.ToListAsync();
        }

        //// GET: api/TriggersReactions/5
        //[HttpGet("{id}")]
        //public async Task<LinkedList<TriggersReactions>> GetTriggersReactions(long id)
        //{
          
        //    var reactions = new LinkedList<Reaction>();

        //    foreach (var item in triggersReactions)
        //    {
        //        reactions.AddLast(_context.Reactions.FindAsync(item.ReactionID).Result);
        //    }

        //    return triggersReactions;
        //}

        // PUT: api/TriggersReactions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTriggersReactions(long id, TriggersReactions triggersReactions)
        {
            if (id != triggersReactions.TriggerId)
            {
                return BadRequest();
            }

            _context.Entry(triggersReactions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TriggersReactionsExists(id))
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

        // POST: api/TriggersReactions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TriggersReactions>> PostTriggersReactions(TriggersReactions triggersReactions)
        {
            _context.triggersReactions.Add(triggersReactions);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TriggersReactionsExists(triggersReactions.TriggerId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTriggersReactions", new { id = triggersReactions.TriggerId }, triggersReactions);
        }

        // DELETE: api/TriggersReactions/5
        [HttpDelete("Trigger/{TriggerID}/Reaction/{ReactionID}")]
        public async Task<ActionResult<TriggersReactions>> DeleteTriggersReactions(long TriggerID, long ReactionID)
        {
            var triggersReactions = await _context.triggersReactions.FindAsync(TriggerID, ReactionID);

            if (triggersReactions == null)
            {
                return NotFound();
            }

            _context.triggersReactions.Remove(triggersReactions);
            await _context.SaveChangesAsync();

            return triggersReactions;
        }

        private bool TriggersReactionsExists(long id)
        {
            return _context.triggersReactions.Any(e => e.TriggerId == id);
        }
    }
}
