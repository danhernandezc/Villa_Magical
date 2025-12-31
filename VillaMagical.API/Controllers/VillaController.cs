using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VillaMagical.Application.DTOs;

namespace VillaMagical.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        public VillaController()
        {
            
        }

        [HttpPost]
        public IActionResult CreateVilla([FromBody] VillaDto villa)
        {
            // ModelState se valida automáticamente
            return CreatedAtAction(nameof(GetVillaById),
                new { id = villa.Id },
                villa);
        }

        [HttpGet("{id:int}")]
        public ActionResult<VillaDto> GetVillaById(int id)
        {
            var villa = new VillaDto
            {
                Id = id,
                Name = "Luxury Villa",
                Occupancy = 4,
                Price = 3500.00m
            };

            return Ok(villa);
        }

    }
}
