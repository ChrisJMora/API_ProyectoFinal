using API_TouristBay.Data;
using API_TouristBay.Models.Passengers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_TouristBay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YoungerController : Controller
    {
        private readonly ApplicationDBContext _db;

        public YoungerController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Younger> younger = await _db.Younger.ToListAsync();
            return Ok(younger);
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
        public async Task<IActionResult> Post([FromBody] Younger younger)
        {
            Younger? younger2 = await _db.Younger.FirstOrDefaultAsync
                (x => x.IdPassenger == younger.IdPassenger);
            if (younger2 == null && younger != null)
            {
                await _db.Younger.AddAsync(younger);
                await _db.SaveChangesAsync();
                return Ok();
            }
            return BadRequest("El objeto ya existe");
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{idPassenger}")]
        public async Task<IActionResult> Put(int idPassenger, [FromBody] Younger younger)
        {
            Younger? younger2 = await _db.Younger.FirstOrDefaultAsync(x => x.IdPassenger == idPassenger);
            if (younger != null && younger2 != null )
            {
                younger2.FirstNamePassenger = younger.FirstNamePassenger != null ?
                    younger.FirstNamePassenger : younger2.FirstNamePassenger;
                younger2.LastNamePassenger = younger.LastNamePassenger != null ?
                    younger.LastNamePassenger : younger2.LastNamePassenger;

                younger2.GenderPassenger = younger.GenderPassenger;
                younger2.AdultYounger = younger.AdultYounger;

                _db.Younger.Update(younger2);

                await _db.SaveChangesAsync();
                return Ok(younger2);
            }
            return BadRequest("El producto no existe");
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{idMenorEdad}")]
        public async Task<IActionResult> Delete(int idYounger)
        {
            Younger? younger = await _db.Younger.FirstOrDefaultAsync
                (x => x.IdPassenger == idYounger);
            if (younger != null)
            {
                _db.Younger.Remove(younger);
                await _db.SaveChangesAsync();
                return NoContent();
            }
            return BadRequest();
        }
    }
}
