namespace HotelReservationSystem.Models.Request
{
    public class RoomReservationRequest
    {
        public Guest Guest { get; set; }
        public int[]? RoomIds { get; set;}
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
