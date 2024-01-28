using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RoomReserved> RoomsReserved { get; set; }
    }
}
