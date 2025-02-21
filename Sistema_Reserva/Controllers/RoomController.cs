using Microsoft.AspNetCore.Mvc;
using Sistema_Reserva.Model;
using Sistema_Reserva.Repository.RoomsRepository;

namespace Sistema_Reserva.Controllers
{
    [ApiController]
    [Route("/")]
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

        

    }
}
