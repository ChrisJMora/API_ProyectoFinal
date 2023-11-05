using API_TouristBay.Data;
using API_TouristBay.Models.Passengers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_TouristBay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdultController : Controller
    {
        private readonly ApplicationDBContext _db;
        public AdultController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Adult> adults = await _db.Adult.ToListAsync();
            return Ok(adults);
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
        public async Task<IActionResult> Post([FromBody] Adult adult)
        {
            Adult? adulto2 = await _db.Adult.
                FirstOrDefaultAsync(x => x.IdPassenger == adult.IdPassenger);
            if (adulto2 == null && adult != null)
            {
                await _db.Adult.AddAsync(adult);
                await _db.SaveChangesAsync();
                return Ok();
            }
            return BadRequest("El objeto ya existe");
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{idPassenger}")]
        public async Task<IActionResult> Put(int idPassenger, [FromBody] Adult adult)
        {
            Adult? adult2 = await _db.Adult.FirstOrDefaultAsync(x => x.IdPassenger == idPassenger);
            if (adult2 != null)
            {
                adult2.FirstNamePassenger = adult.FirstNamePassenger != null ?
                    adult.FirstNamePassenger : adult2.FirstNamePassenger;
                adult2.LastNamePassenger = adult.LastNamePassenger != null ? 
                    adult.LastNamePassenger : adult2.LastNamePassenger;
                adult2.GenderPassenger = adult.GenderPassenger;
                adult2.EmailAdult = adult.EmailAdult != null ? adult.EmailAdult : adult2.EmailAdult;
                adult2.PhoneAdult = adult.PhoneAdult != null ? adult.PhoneAdult : adult2.PhoneAdult;

                _db.Adult.Update(adult2);

                await _db.SaveChangesAsync();
                return Ok(adult2);
            }
            return BadRequest("El producto no existe");
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{idAdulto}")]
        public async Task<IActionResult> Delete(int idAdulto)
        {
            Adult? adulto = await _db.Adult.FirstOrDefaultAsync
                (x => x.IdPassenger == idAdulto);
            if (adulto != null)
            {
                _db.Adult.Remove(adulto);
                await _db.SaveChangesAsync();
                return NoContent();
            }
            return BadRequest();
        }

    }
}
