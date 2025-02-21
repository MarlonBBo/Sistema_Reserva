using Sistema_Reserva.DTO;
using Sistema_Reserva.Model;
using Sistema_Reserva.Repository.ReservesRepository;
using Sistema_Reserva.Repository.UsersRepository;

namespace Sistema_Reserva.Service
{
    public class ReserveService
    {
        private readonly IReserveRepository _reserveRepository;
        private readonly IUserRepository _userRepository;

        public ReserveService(IReserveRepository reservationRepository, IUserRepository userRepository)
        {
            _reserveRepository = reservationRepository;
            _userRepository = userRepository;
        }

        public async Task<(Reserve, List<string> participants)> CreateReservationAsync(ReserveDTO reserveDTO)
        {
            var reservation = new Reserve
            {
                RoomId = reserveDTO.RoomId,
                UserId = reserveDTO.UserId,
                AttendeeCount = reserveDTO.AttendeeCount
            };


            var createdReservation = await _reserveRepository.CreateReserve(reservation);

            var participants = await _userRepository.GetUsersById(reserveDTO.Participants);
            var participantsName = participants.Select(x => x.Name).ToList();
            

            return (createdReservation, participantsName);
        }

    }
}