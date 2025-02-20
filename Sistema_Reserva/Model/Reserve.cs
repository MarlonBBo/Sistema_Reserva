using System.ComponentModel.DataAnnotations;

namespace Sistema_Reserva.Model
{
    public class Reserve
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Room Room { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade de participantes deve ser pelo menos 1.")]
        public int AttendeeCount { get; set; }

    }
}
