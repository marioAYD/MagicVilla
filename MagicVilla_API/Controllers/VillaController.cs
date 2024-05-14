using MagicVilla_API.Datos;
using MagicVilla_API.Modelos.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            //return new List<VillaDto>
            //{
            //    new VillaDto { Id = 1,Nombre="Vista a la piscina"},
            //    new VillaDto { Id = 2,Nombre="Vista a la Playa"}
            //};
            return Ok(VillaStore.villaList);
        }

        [HttpGet("id:int")]
        public ActionResult<VillaDto> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.villaList.FirstOrDefault(v => v.Id == id);
            if (villa == null)
            {
                return NotFound();
            }

            return (villa);
        }
    }
}
