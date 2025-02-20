using Sistema_Reserva.Model;

namespace Sistema_Reserva.Repository.UsersRepository
{
    public interface IUserRepository
    {
        Task<ResponseModel<List<User>>> CreateUser(User createUser);
        Task<ResponseModel<List<User>>> DeleteUser(int idUser);
        Task<ResponseModel<List<User>>> ListUsers();
        Task<ResponseModel<List<User>>> GetUsersById(List<int> idsUsers);
    }
}
