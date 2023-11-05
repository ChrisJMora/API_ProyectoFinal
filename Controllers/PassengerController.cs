using API_TouristBay.Data;
using API_TouristBay.Models.Passengers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_TouristBay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : Controller
    {
        private readonly ApplicationDBContext _db;

        public PassengerController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Passenger> passengers = await _db.Passenger.ToListAsync();
            return Ok(passengers);
        }

        // GET api/<ProductoController>/5
        [HttpGet("{idPassenger}")]
        public async Task<IActionResult> Get(int idPassenger)
        {
            Passenger? passenger = await _db.Passenger.FirstOrDefaultAsync(x => x.IdPassenger == idPassenger);
            if (passenger == null) { return BadRequest(); }
            return Ok(passenger);
        }

        // POST api/<ProductoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Passenger passsenger)
        {
            Passenger? passenger2 = await _db.Passenger.FirstOrDefaultAsync
                (x => x.IdPassenger == passsenger.IdPassenger);
            if (passenger2 == null && passsenger != null)
            {
                await _db.Passenger.AddAsync(passsenger);
                await _db.SaveChangesAsync();
                return Ok();
            }
            return BadRequest("El objeto ya existe");
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete]
        public async Task<IActionResult> Delete(int idPassenger)
        {
            List<Passenger> pasajeros = await _db.Passenger.ToListAsync();
            _db.Passenger.RemoveRange(pasajeros);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
