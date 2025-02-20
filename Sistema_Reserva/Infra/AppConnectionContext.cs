using Microsoft.EntityFrameworkCore;
using Sistema_Reserva.Model;

namespace Sistema_Reserva.Infra
{
    public class AppConnectionContext : DbContext
    {
        public AppConnectionContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Reserve> Reserves { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
