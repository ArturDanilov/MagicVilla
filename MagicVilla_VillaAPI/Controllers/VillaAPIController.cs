using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    // ControllerBase - это класс, который содержит методы и свойства, необходимые для создания контроллера API???
    // Он должен быть унаследован от ControllerBase чтобы обладать базовой функцинальностью контроллеров
    [Route("api/VillaAPI")] // атрибут, который указывает, что класс будет вызываться при GET-запросе
    [ApiController] 
    public class VillaAPIController : ControllerBase // класс, который содержит методы и свойства, необходимые для создания контроллера API
    {
        // GET: api/VillaAPI
        [HttpGet] // атрибут, который указывает, что метод будет вызываться при GET-запросе
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult <IEnumerable<VillaDTO>> GetVillas() // метод, который возвращает список объектов Villa
        {
            return Ok(VillaStore.villasList); // возвращает список объектов Villa
        }

        // GET: api/VillaAPI/5
        [HttpGet("{id}", Name = "Get")] // атрибут, который указывает, что метод будет вызываться при GET-запросе
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200, Type = typeof(VillaDTO))]
        public ActionResult<VillaDTO> GetVilla(int id) // метод, который возвращает список объектов Villa по id
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var villa = VillaStore.villasList.FirstOrDefault(c => c.Id == id); // возвращает объект Villa по id

            if (villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }
    }
}
