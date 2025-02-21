using Microsoft.EntityFrameworkCore;
using Sistema_Reserva.Infra;
using Sistema_Reserva.Model;

namespace Sistema_Reserva.Repository.RoomsRepository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppConnectionContext _context;

        public RoomRepository(AppConnectionContext connectionContext)
        {
            _context = connectionContext;
        }

        public async Task<ResponseModel<List<Room>>> CreateRoom(Room createRoom)
        {
            ResponseModel<List<Room>> response = new ResponseModel<List<Room>>();

            try
            {
                var room = new Room()
                {
                    Name = createRoom.Name,
                    Capacity = createRoom.Capacity,
                };

                _context.Add(room);
                await _context.SaveChangesAsync();

                response.Data = await _context.Rooms.ToListAsync();
                response.Message = "Sala criada";
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<ResponseModel<List<Room>>> DeleteRoom(int idRoom)
        {
            ResponseModel<List<Room>> response = new ResponseModel<List<Room>>();

            try
            {
                var room = await _context.Rooms.FirstOrDefaultAsync(r => r.Id == idRoom);

                if (room == null)
                {
                    response.Message = "Sala não encontrada";
                    return response;
                }

                _context.Remove(room);
                await _context.SaveChangesAsync();

                response.Data = await _context.Rooms.ToListAsync();
                response.Message = "Sala deletada com sucesso";
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
        public async Task<ResponseModel<List<Room>>> ListRoom()
        {
            ResponseModel<List<Room>> response = new ResponseModel<List<Room>>();

            try
            {
                var room = await _context.Rooms.ToListAsync();
                
                if (room == null)
                {
                    response.Message = "Não há salas criadas";
                    return response;
                }

                response.Data = room;
                response.Message = "Lista de salas";
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
