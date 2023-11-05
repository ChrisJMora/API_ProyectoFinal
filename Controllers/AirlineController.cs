using API_TouristBay.Data;
using API_TouristBay.Models.Catalogues;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_TouristBay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirlineController : Controller
    {
        private readonly ApplicationDBContext _db;
        public AirlineController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Airline> aerolineas = await _db.Airline.ToListAsync();
            return Ok(aerolineas);
        }

    }
}
