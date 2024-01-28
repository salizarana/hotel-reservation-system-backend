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
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal NetTotal{ get; set; }
        public DateTime CreatedAt { get; set; }
        [ForeignKey("GuestId")]
        public int GuestId { get; set; }
        public ICollection<RoomReserved> RoomsReserved { get; set; }
    }
}
