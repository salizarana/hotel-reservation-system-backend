using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Models
{
    public class RoomContext: DbContext
    {
        public RoomContext(DbContextOptions<RoomContext> options) : base(options) { }

        public DbSet<Room> Rooms { get; set; } = null!;
    }
}
