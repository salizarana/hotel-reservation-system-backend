namespace HotelReservationSystem.Models
{
    public class Room
    {
        public int Id { get; set; } 
        public string? RoomNumber { get; set; }
        public string? RoomType { get; set; }
        public int Capacity { get; set; }
        public float PricePerNight { get; set; }
        public bool IsBooked { get; set; }
        public string? Description { get; set; }
        public string[]? Photos { get; set; } 
        public string[]? Features { get; set; }
    }
}
