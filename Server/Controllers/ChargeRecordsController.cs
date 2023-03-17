using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeccaUI_THDxIOT.Server.Data;
using MeccaUI_THDxIOT.Shared;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.SignalR;
using MeccaUI_THDxIOT.Server.Hubs;
using Microsoft.AspNetCore.SignalR.Client;

namespace MeccaUI_THDxIOT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChargeRecordsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private IHubContext<MainHub> HubContext { get; set; }




        public ChargeRecordsController(ApplicationDbContext context,
             IHubContext<MainHub> hubcontext)
        {
            _context = context;
            HubContext = hubcontext;
        }

        // GET: api/ChargeRecords
        [HttpGet]
        public async Task<ActionResult<ChargeRecord>> GetChargeRecord()
        {
             
            var chargeRecords  = await _context.ChargeRecord.ToListAsync();

            if (chargeRecords == null)
            {
                return NotFound();
            }
            var LastRecord = chargeRecords.Last();
            return LastRecord;
        }

        // GET: api/ChargeRecords/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChargeRecord>> GetChargeRecord(long id)
        {
            var chargeRecord = await _context.ChargeRecord.FindAsync(id);

            if (chargeRecord == null)
            {
                return NotFound();
            }

            return chargeRecord;
        }

        // PUT: api/ChargeRecords/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut()]
        public async Task<IActionResult> PutChargeRecord(ChargeRecord chargeRecord)
        {
            chargeRecord.ChargeRecord_ID = _context.ChargeRecord.LastOrDefault().ChargeRecord_ID;
            
            if (chargeRecord.ChargeRecord_ID == 0)
            {
                return BadRequest();
            }

            _context.Entry(chargeRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            { 
               throw;
            }
            return NoContent();
        }

        // POST: api/ChargeRecords
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChargeRecord>> PostChargeRecord(ChargeRecord chargeRecord)
        {
            _context.ChargeRecord.Add(chargeRecord);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChargeRecordExists(chargeRecord.ChargeRecord_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            await HubContext.Clients.All.SendAsync("ReceiveChargeRec",       //Connect the Hub to Update Battery Data and refresh the view automaticlly
                                                    chargeRecord.IsCharging,
                                                    chargeRecord.ChargeLevel);


            return CreatedAtAction("GetChargeRecord", new { id = chargeRecord.ChargeRecord_ID }, chargeRecord);
        }

        // DELETE: api/ChargeRecords/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChargeRecord>> DeleteChargeRecord(long id)
        {
            var chargeRecord = await _context.ChargeRecord.FindAsync(id);
            if (chargeRecord == null)
            {
                return NotFound();
            }

            _context.ChargeRecord.Remove(chargeRecord);
            await _context.SaveChangesAsync();

            return chargeRecord;
        }

        private bool ChargeRecordExists(double id)
        {
            return _context.ChargeRecord.Any(e => e.ChargeRecord_ID == id);
        }
    }
}
