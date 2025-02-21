using Sistema_Reserva.Model;

namespace Sistema_Reserva.Repository.RoomsRepository
{
    public interface IRoomRepository
    {
        Task<ResponseModel<List<Room>>> CreateRoom(Room createRoom);
        Task<ResponseModel<List<Room>>> DeleteRoom(int idRoom);
        Task<ResponseModel<List<Room>>> ListRoom();
    }
}
