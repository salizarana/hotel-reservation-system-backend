using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Models
{
    public class GuestContext: DbContext
    {
        public GuestContext(DbContextOptions<GuestContext> options) : base(options)
        {
        }

        public DbSet<Guest> Guests { get; set; } = null!;
    }
}
