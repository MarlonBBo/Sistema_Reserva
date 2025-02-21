using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using Sistema_Reserva.Infra;
using Sistema_Reserva.Model;

namespace Sistema_Reserva.Repository.UsersRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppConnectionContext _context;

        public UserRepository(AppConnectionContext connectionContext)
        {
            _context = connectionContext;
        }

        public async Task<ResponseModel<List<User>>> CreateUser(User createUser)
        {
            ResponseModel<List<User>> response = new ResponseModel<List<User>>();

            try
            {

                var user = new User()
                {
                    Name = createUser.Name
                };

                _context.Add(user);
                await _context.SaveChangesAsync();

                response.Data = await _context.Users.ToListAsync();
                response.Message = "Usuário Criado!";
                return response;

            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                return response;
            }
        }

        public async Task<ResponseModel<List<User>>> DeleteUser(int idUser)
        {
            ResponseModel<List<User>> resposta = new ResponseModel<List<User>>();

            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(a => a.Id == idUser);

                if (user == null)
                {
                    resposta.Message = "Usuário não encontrado";
                    return resposta;
                }

                _context.Remove(user);
                await _context.SaveChangesAsync();

                resposta.Data = await _context.Users.ToListAsync();
                resposta.Message = "Usuário deletado com sucesso!";
                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Message = ex.Message;
                return resposta;
            }
        }

        public Task<ResponseModel<List<User>>> GetUsersById(List<int> idsUsers)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<User>>> ListUsers()
        {
            ResponseModel<List<User>> resposta = new ResponseModel<List<User>>();
            try
            {
                var users = await _context.Users.ToListAsync();
                resposta.Data = users;
                resposta.Message = "Deu tudo certo!";
                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Message = ex.Message;
                return resposta;
            }
        }
    }
}
