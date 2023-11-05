using API_TouristBay.Data;
using API_TouristBay.Models.Catalogues;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_TouristBay.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly ApplicationDBContext _db;

        public CityController(ApplicationDBContext db)
        {
            _db = db;
        }

        // GET: api/<ProductoController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<City> ciudades = await _db.City.ToListAsync();
            return Ok(ciudades);
        }

    }
}
