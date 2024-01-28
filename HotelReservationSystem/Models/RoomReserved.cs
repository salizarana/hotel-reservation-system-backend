using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelReservationSystem.Models
{
    public class RoomReserved
    {
        [Key]
        public int Id {  get; set; }
       
        [ForeignKey("RoomId")]
        public int RoomID { get; set; }
        public string RoomType { get; set; }
        public decimal RatePerNight { get; set; }

        [ForeignKey("ReservationId")]
        public int ReservationId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
