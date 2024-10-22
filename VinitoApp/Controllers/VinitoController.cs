using Common.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace VinitoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class VinitoController : ControllerBase
    {
        #region Inyecction de WineService
        private readonly IWineService _wineService;
        public VinitoController(IWineService wineService)
        {
            _wineService = wineService;
        }
        #endregion

        [HttpGet]
        public IActionResult QuienSeHaTomadoTodoElVino()
        {
            return Ok(_wineService.getAllWines());
        }

        [HttpPost]
        public IActionResult agregarVinito([FromBody] VinoForCreateDTO vinoNuevo)
        {
            VinoForCreateDTO newWine = new VinoForCreateDTO()
            {
                Name = vinoNuevo.Name,
                Variety = vinoNuevo.Variety,
                Year = vinoNuevo.Year,
                Region = vinoNuevo.Region,
                Stock = vinoNuevo.Stock
                //CreatedAt se crea solo, con el valor por defecto de cuando corro el metodo
            };
            int vinoNuevoId = _wineService.addWine(newWine); //Guardo el ID para hacer algo con el front
            return Ok(vinoNuevoId);
        }

        [HttpPut("{wineId}")]
        public IActionResult cambiarStock([FromBody] int cantidad, [FromRoute] int wineId)
        {
            WineForModifyDTO wineForModify = new WineForModifyDTO()
            {
                Id = wineId,
                NewStock = cantidad
            };
            var bandera = _wineService.modifyStock(wineForModify);
            if (bandera) {
                return Ok();
            }
            else {
                return BadRequest();
            }
        }

    }
}
