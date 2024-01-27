using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservationSystem.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        public required DateTime CheckInDate { get; set; }
        public required DateTime CheckOutDate { get; set; }
        public float DiscountPercent { get; set; }
        public required float TotalAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("GuestId")]
        public required int GuestId { get; set; }
        public required Guest Guest { get; set; }
        public ICollection<RoomReserved> RoomsReserved { get; set; } = null!;
    }
}
