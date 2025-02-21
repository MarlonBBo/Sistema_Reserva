using Microsoft.AspNetCore.Mvc;
using Sistema_Reserva.Model;
using Sistema_Reserva.Repository.UsersRepository;

namespace Sistema_Reserva.Controllers
{
    [ApiController]
    [Route("/")]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("CreteUser")]
        public async Task<ActionResult<ResponseModel<List<User>>>> CreateUser(User crateUser)
        {
            var user = await _userRepository.CreateUser(crateUser);
            return Ok(user);
        }

        [HttpGet("ListUsers")]
        public async Task<ActionResult<ResponseModel<List<User>>>> ListUsers()
        {
            var users = await _userRepository.ListUsers();
            return Ok(users);
        }

        [HttpDelete("DeleteUser/{idUser}")]
        public async Task<ActionResult<ResponseModel<List<User>>>> DeleteUser(int idUser)
        {
            var user = await _userRepository.DeleteUser(idUser);
            return Ok(user);
        }

        [HttpGet("GetUsersById")]
        public async Task<ActionResult<ResponseModel<List<User>>>> GetUsersById([FromQuery] List<int> idsUsers)
        {
            var users = await _userRepository.GetUsersById(idsUsers);
            return Ok(users);
        }

    }
}
