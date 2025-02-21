using Sistema_Reserva.Model;
using System.Text.Json.Serialization;

namespace Sistema_Reserva.DTO
{
    public class ReserveDTO
    {
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public int AttendeeCount { get; set; }
        public List<int> Participants { get; set; }


    }
}
