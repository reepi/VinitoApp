using Common.DTOs;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace VinitoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        #region Inyeccion de UserService
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        //Crear Usuario
        [HttpPost]
        public IActionResult createUser([FromBody] UserForCreateDTO userForCreate)
        {
            UserForCreateDTO newUser = new UserForCreateDTO()
            {
                Username = userForCreate.Username,
                Password = userForCreate.Password
            };
            int newUserId = _userService.createUser(newUser); //Guardo el ID del usuario que cree para hacer algo mas tarde
            return Created();
        }
    }
}
