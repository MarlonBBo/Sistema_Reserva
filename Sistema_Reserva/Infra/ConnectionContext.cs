using Microsoft.EntityFrameworkCore;
using Sistema_Reserva.Model;

namespace Sistema_Reserva.Infra
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Meeting> Meetings { get; set; }
        DbSet<Reserve> Reserves { get; set; }
        DbSet<Room> Rooms { get; set; }
        DbSet<User> Users { get; set; }
    }
}
