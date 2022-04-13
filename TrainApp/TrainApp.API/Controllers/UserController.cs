using TrainApp.Services;
using Microsoft.AspNetCore.Mvc;
using TrainApp.Dtos;

namespace TrainApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }




        // GET: api/<ItemController>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult GetAllUsers()
        {
            var result = _userService.Get();
            return Ok(result);
        }
    }
}
