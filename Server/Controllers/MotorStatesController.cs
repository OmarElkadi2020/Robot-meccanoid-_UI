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
    public class MotorStatesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MotorStatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/MotorStates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MotorState>>> GetMotorStates()
        {
            return await _context.MotorStates.ToListAsync();
        }

        // GET: api/MotorStates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MotorState>> GetMotorState(long id)
        {
            var motorState = await _context.MotorStates.FindAsync(id);

            if (motorState == null)
            {
                return NotFound();
            }

            return motorState;
        }

        // PUT: api/MotorStates/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMotorState(long id, MotorState motorState)
        {
            if (id != motorState.MotorStateID)
            {
                return BadRequest();
            }

            _context.Entry(motorState).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MotorStateExists(id))
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

        // POST: api/MotorStates
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<MotorState>> PostMotorState(MotorState motorState)
        {
            _context.MotorStates.Add(motorState);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMotorState", new { id = motorState.MotorStateID }, motorState);
        }

        // DELETE: api/MotorStates/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MotorState>> DeleteMotorState(long id)
        {
            var motorState = await _context.MotorStates.FindAsync(id);
            if (motorState == null)
            {
                return NotFound();
            }

            _context.MotorStates.Remove(motorState);
            await _context.SaveChangesAsync();

            return motorState;
        }

        private bool MotorStateExists(long id)
        {
            return _context.MotorStates.Any(e => e.MotorStateID == id);
        }
    }
}
