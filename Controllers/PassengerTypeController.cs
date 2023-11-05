using API_TouristBay.Data;
using API_TouristBay.Models.Passengers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_TouristBay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerTypeController : Controller
    {
        private readonly ApplicationDBContext _db;

        public PassengerTypeController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<PassengerType> passengersType = await _db.PassengerType.ToListAsync();
            return Ok(passengersType);
        }
    }
}
