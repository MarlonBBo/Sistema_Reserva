using Sistema_Reserva.Model;

namespace Sistema_Reserva.Repository.ReservesRepository
{
    public interface IReserveRepository
    {
        Task<Reserve> CreateReserve(Reserve reserve);
        Task<ResponseModel<List<Reserve>>> DeleteReserve(int idReserve);
        Task<ResponseModel<List<Reserve>>> ListReserve();
    }
}
