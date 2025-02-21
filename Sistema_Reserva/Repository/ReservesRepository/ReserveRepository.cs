using Microsoft.EntityFrameworkCore;
using Sistema_Reserva.Infra;
using Sistema_Reserva.Model;

namespace Sistema_Reserva.Repository.ReservesRepository
{
    public class ReserveRepository : IReserveRepository
    {
        private readonly AppConnectionContext _context;

        public ReserveRepository(AppConnectionContext context)
        {
            _context = context;
        }

        public async Task<Reserve> CreateReserve(Reserve reserve)
        {
            ResponseModel<List<Reserve>> response = new ResponseModel<List<Reserve>>();

            _context.Reserves.Add(reserve);
            await _context.SaveChangesAsync();
            return reserve;
        }

        public async Task<ResponseModel<List<Reserve>>> DeleteReserve(int idReserve)
        {
            ResponseModel<List<Reserve>> response = new ResponseModel<List<Reserve>>();

            try
            {
                var reserve = await _context.Reserves.FirstOrDefaultAsync(r => r.Id == idReserve);

                if (reserve == null)
                {
                    response.Message = "Reserva não encontrada";
                    return response;
                }

                _context.Remove(reserve);
                await _context.SaveChangesAsync();

                response.Data = await _context.Reserves.ToListAsync();
                response.Message = "Reserva deletada com sucesso";
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<ResponseModel<List<Reserve>>> ListReserve()
        {
            ResponseModel<List<Reserve>> response = new ResponseModel<List<Reserve>>();

            try
            {
                var reserve = await _context.Reserves.ToListAsync();

                if (reserve == null)
                {
                    response.Message = "Não há reserva criadas";
                    return response;
                }

                response.Data = reserve;
                response.Message = "Lista de reservas";
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
