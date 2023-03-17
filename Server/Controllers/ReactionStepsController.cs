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
    public class ReactionStepsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReactionStepsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ReactionSteps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReactionStep>>> GetReactionSteps()
        {
            return await _context.ReactionSteps.ToListAsync();
        }

        // GET: api/ReactionSteps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ReactionStep>> GetReactionStep(long id)
        {
            var reactionStep = await _context.ReactionSteps.FindAsync(id);

            if (reactionStep == null)
            {
                return NotFound();
            }

            return reactionStep;
        }

        // PUT: api/ReactionSteps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReactionStep(long id, ReactionStep reactionStep)
        {
            if (id != reactionStep.ReactionStepID)
            {
                return BadRequest();
            }

            _context.Entry(reactionStep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReactionStepExists(id))
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

        // POST: api/ReactionSteps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ReactionStep>> PostReactionStep(ReactionStep reactionStep)
        {
            _context.ReactionSteps.Add(reactionStep);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReactionStep", new { id = reactionStep.ReactionStepID }, reactionStep);
        }

        // DELETE: api/ReactionSteps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ReactionStep>> DeleteReactionStep(long id)
        {
            var reactionStep = await _context.ReactionSteps.FindAsync(id);
            if (reactionStep == null)
            {
                return NotFound();
            }

            _context.ReactionSteps.Remove(reactionStep);
            await _context.SaveChangesAsync();

            return reactionStep;
        }

        private bool ReactionStepExists(long id)
        {
            return _context.ReactionSteps.Any(e => e.ReactionStepID == id);
        }
    }
}
