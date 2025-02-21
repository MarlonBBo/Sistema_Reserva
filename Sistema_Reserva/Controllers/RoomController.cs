using Microsoft.AspNetCore.Mvc;
using Sistema_Reserva.Model;
using Sistema_Reserva.Repository.RoomsRepository;

namespace Sistema_Reserva.Controllers
{
    [ApiController]
    [Route("/Room")]
    public class RoomController : ControllerBase
    {

        private readonly IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        [HttpPost("CreateRoom")]
        public async Task<ActionResult<ResponseModel<List<Room>>>> CreateRoom(Room createRoom)
        {
            var room = await _roomRepository.CreateRoom(createRoom);
            return Ok(room);
        }

        [HttpGet("ListRoom")]
        public async Task<ActionResult<ResponseModel<List<Room>>>> ListRoom()
        {
            var room = await _roomRepository.ListRoom();
            return Ok(room);
        }

        [HttpDelete("DeleteRoom/{idRoom}")]
        public async Task<ActionResult<ResponseModel<List<Room>>>> DeleteRoom(int idRoom)
        {
            var room = await _roomRepository.DeleteRoom(idRoom);
            return Ok(room);
        }

    }
}
