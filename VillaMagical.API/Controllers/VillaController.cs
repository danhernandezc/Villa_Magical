using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
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
        private readonly ILogger<VillaController> _logger;

        public VillaController(ILogger<VillaController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
         _logger.LogInformation($"{nameof(GetVillas)} - Obteniendo la informacion!");
            return Ok(VillaStore.VillaList);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public IActionResult CreateVilla([FromBody] VillaDto villa)
        {

            if (villa == null)
            {
                _logger.LogError($"{nameof(GetVillas)} - Obteniendo el error!");
                return BadRequest(villa);
            }

            if (villa.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            villa.Id = VillaStore.VillaList.OrderByDescending(v => v.Id).FirstOrDefault().Id+1;
            VillaStore.VillaList.Add(villa);

            // ModelState se valida automáticamente
            return CreatedAtAction(nameof(GetVillaById),
                new { id = villa.Id },
                villa);
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<VillaDto> GetVillaById(int id)
        {

            if (id==0)
            {
                return BadRequest();
            }


           var firstVilla =  VillaStore.VillaList.FirstOrDefault(x => x.Id == id);

            if (firstVilla is null)
            {
                return NotFound();
            }

            return Ok(firstVilla);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdateVilla(int id, VillaUpdateDto dto)
        {
            if (dto == null || id != dto.Id)
                return BadRequest("Datos inválidos");

            var villa = VillaStore.VillaList.FirstOrDefault(x => x.Id == id);

            if (villa == null)
                return NotFound();

            villa.Name = dto.Name;

            return NoContent();
        }

        // ============================
        // PATCH: api/villas/1
        // ============================
        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult UpdatePartialVilla(
            int id,
            [FromBody] JsonPatchDocument<VillaUpdateDto> patchDto)
        {
            if (patchDto == null)
                return BadRequest();

            var villa = VillaStore.VillaList.FirstOrDefault(x => x.Id == id);

            if (villa == null)
                return NotFound();

            var villaToPatch = new VillaUpdateDto
            {
                Id = villa.Id,
                Name = villa.Name
            };

            patchDto.ApplyTo(villaToPatch, ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            villa.Name = villaToPatch.Name;

            return NoContent();
        }

        // ============================
        // DELETE: api/villas/1
        // ============================
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteVilla(int id)
        {
            if (id <= 0)
                return BadRequest();

            var villa = VillaStore.VillaList.FirstOrDefault(x => x.Id == id);

            if (villa == null)
                return NotFound();

            VillaStore.VillaList.Remove(villa);

            return NoContent();
        }

        // ============================
        // HEAD: api/villas/1
        // ============================
        [HttpHead("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult HeadVilla(int id)
        {
            var exists = VillaStore.VillaList.Any(x => x.Id == id);
            return exists ? Ok() : NotFound();
        }

        // ============================
        // OPTIONS: api/villas
        // ============================
        [HttpOptions]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Options()
        {
            Response.Headers.Add("Allow", "GET, POST, PUT, PATCH, DELETE, OPTIONS, HEAD");
            return Ok();
        }

    }
}
