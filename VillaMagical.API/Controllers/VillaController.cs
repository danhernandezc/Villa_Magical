using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VillaMagical.Application.DTOs;
using VillaMagical.Application.StaticData;

namespace VillaMagical.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        public VillaController()
        {
            
        }
        [HttpGet]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
         
            return Ok(VillaStore.VillaList);
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
           var firstVilla =  VillaStore.VillaList.FirstOrDefault(x => x.Id == id);

            if (firstVilla is null)
            {
                return NotFound();
            }

            return Ok(firstVilla);
        }

    }
}
