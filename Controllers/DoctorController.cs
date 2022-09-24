using backendCode.Data;
using backendCode.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backendCode.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DoctorController : Controller
    {
        private readonly DoctorDbContext _doctorDbContext;

        public DoctorController(DoctorDbContext doctorDbContext)
        {
            _doctorDbContext = doctorDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDoctors()
        {
            var doctors = await _doctorDbContext.Doctors.ToListAsync();

            return Ok(doctors);

        }

        [HttpPost]
        public async Task<IActionResult> AddDoctor([FromBody] Doctor doctorRequest)
        {
            

            await _doctorDbContext.Doctors.AddAsync(doctorRequest);
            await _doctorDbContext.SaveChangesAsync();

            return Ok(doctorRequest);
        }
    }
}
