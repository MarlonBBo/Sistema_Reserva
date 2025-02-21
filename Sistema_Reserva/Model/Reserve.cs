using System.ComponentModel.DataAnnotations;

namespace Sistema_Reserva.Model
{
    public class Reserve
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public int AttendeeCount { get; set; }

        public User User { get; set; }
        public Room Room { get; set; }
    }
}
