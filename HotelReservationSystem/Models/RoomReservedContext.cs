using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Models
{
    public class RoomReservedContext: DbContext
    {
        public RoomReservedContext(DbContextOptions<RoomReservedContext> options) : base(options) { }

        public DbSet<RoomReserved> RoomsReserved { get; set; } = null!;
    }
}
