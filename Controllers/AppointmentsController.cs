using backendCode.Data;
using backendCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendCode.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AppointmentsController : Controller
    {
        private readonly AppointmentDbContext _appointementDbContext;

        public AppointmentsController(AppointmentDbContext appointementDbContext)
        {
            _appointementDbContext = appointementDbContext;
        }
        [HttpGet]
        public async Task<IActionResult>  GetAllAppointments()
        {
            var appointments = await _appointementDbContext.Appointments.ToListAsync();

            return Ok(appointments);

        }

        [HttpPost]
        public async Task<IActionResult> AddAppointment([FromBody] Appointment appointmentRequest)
        {
            appointmentRequest.Id = Guid.NewGuid();

            await _appointementDbContext.Appointments.AddAsync(appointmentRequest);
            await _appointementDbContext.SaveChangesAsync();    

            return Ok(appointmentRequest);  
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteAppointment([FromRoute] Guid id)
        {
            var appointment = await _appointementDbContext.Appointments.FindAsync(id);

            if(appointment == null)
            {
                return NotFound();  
            }
            _appointementDbContext.Appointments.Remove(appointment);
            await _appointementDbContext.SaveChangesAsync();

            return Ok(appointment);

        }
    }
}
