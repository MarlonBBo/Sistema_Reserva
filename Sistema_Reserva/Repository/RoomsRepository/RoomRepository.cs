using Sistema_Reserva.Model;

namespace Sistema_Reserva.Repository.RoomsRepository
{
    public class RoomRepository : IRoomRepository
    {
        public Task<ResponseModel<List<Room>>> CreateRoom(Room createRoom)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<Room>>> DeleteRoom(int idRoom)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<Room>>> GetRoomById(int idRoom)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseModel<List<Room>>> ListRoom()
        {
            throw new NotImplementedException();
        }
    }
}
