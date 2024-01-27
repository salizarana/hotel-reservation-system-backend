namespace HotelReservationSystem.Models.Request
{
    public class RoomSearchRequest
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int GuestCount { get; set;}
        public int RoomCount { get; set;}

    }
}
