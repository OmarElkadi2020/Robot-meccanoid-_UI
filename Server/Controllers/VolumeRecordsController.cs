using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeccaUI_THDxIOT.Server.Data;
using MeccaUI_THDxIOT.Shared;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.SignalR;
using MeccaUI_THDxIOT.Server.Hubs;

namespace MeccaUI_THDxIOT.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VolumeRecordsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;


        private IHubContext<MainHub> HubContext { get; set; }

        public VolumeRecordsController(ApplicationDbContext pContext, IHubContext<MainHub> pHubcontext)
        {
            _context = pContext;
            HubContext = pHubcontext;
        }


        // GET: api/VolumeRecords
        [HttpGet]
        public async Task<ActionResult<VolumeRecord>> GetVolumeRecord()
        {
            var volumeRecords = await _context.VolumeRecord.ToListAsync();

            if (volumeRecords == null)
            {
                return NotFound();
            }
            var LastRecord = volumeRecords.Last();
            return LastRecord;
        }

        // GET: api/VolumeRecords/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VolumeRecord>> GetVolumeRecord(double id)
        {
            var volumeRecord = await _context.VolumeRecord.FindAsync(id);

            if (volumeRecord == null)
            {
                return NotFound();
            }

            return volumeRecord;
        }

        // PUT: api/VolumeRecords/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]

        public async Task<IActionResult> PutVolumeRecord(double id, VolumeRecord volumeRecord)
        {
            if (id != volumeRecord.VolumeRecod_ID)
            {
                return BadRequest();
            }

            _context.Entry(volumeRecord).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolumeRecordExists(id))
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

        // POST: api/VolumeRecords
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<VolumeRecord>> PostVolumeRecord(VolumeRecord volumeRecord)
        {
            _context.VolumeRecord.Add(volumeRecord);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VolumeRecordExists(volumeRecord.VolumeRecod_ID))
                {
                    return Conflict();
                }
               else
                {
                    throw;
                }
            }

            await HubContext.Clients.All.SendAsync("ReciveVolRec"
                                                   , volumeRecord.VolumeLevel ); //  
            
            return CreatedAtAction("GetVolumeRecord", new { id = volumeRecord.VolumeRecod_ID }, volumeRecord);
        }

        // DELETE: api/VolumeRecords/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<VolumeRecord>> DeleteVolumeRecord(double id)
        {
            var volumeRecord = await _context.VolumeRecord.FindAsync(id);
            if (volumeRecord == null)
            {
                return NotFound();
            }

            _context.VolumeRecord.Remove(volumeRecord);
            await _context.SaveChangesAsync();

            return volumeRecord;
        }

        private bool VolumeRecordExists(double id)
        {
            return _context.VolumeRecord.Any(e => e.VolumeRecod_ID == id);
        }
    }
}
