using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public string RoomType { get; set; } = null!;
        public string RoomNumber { get; set; } = null!;

        public required int Capacity { get; set; }
        public required decimal RatePerNight { get; set; }
        public string? Description { get; set; }
        public string[]? Features { get; set; }

        public string[]? Photos { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
