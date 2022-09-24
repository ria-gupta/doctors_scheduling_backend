using backendCode.Data;
using backendCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendCode.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SlotController : Controller
    {
        private SlotDbContext _slotDbContext;

        public SlotController(SlotDbContext slotDbContext)
        {
            _slotDbContext = slotDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSlots()
        {
            var slots = await _slotDbContext.Slots.ToListAsync();

            return Ok(slots);

        }

        [HttpPost]
        public async Task<IActionResult> AddSlot([FromBody] Slot slotRequest)
        {

            await _slotDbContext.Slots.AddAsync(slotRequest);
            await _slotDbContext.SaveChangesAsync();

            return Ok(slotRequest);
        }
    }
}
