using API_TouristBay.Data;
using API_TouristBay.Models.Catalogues;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_TouristBay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : Controller
    {
        private readonly ApplicationDBContext _db;

        public FlightController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Flight> flights = await _db.Flight.ToListAsync();
            return Ok(flights);
        }

        // GET api/<ProductoController>/5
        [HttpGet("{idFlight}")]
        public async Task<IActionResult> Get(string idFlight)
        {
            Flight? flight = await _db.Flight.FirstOrDefaultAsync(x => x.IdFlight.Equals(idFlight));
            if (flight == null) { return BadRequest(); }
            return Ok(flight);  
        }
    }
}
