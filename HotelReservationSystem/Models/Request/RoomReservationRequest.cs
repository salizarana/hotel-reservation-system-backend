namespace HotelReservationSystem.Models.Request
{
    public class RoomReservationRequest
    {
        public Guest Guest { get; set; }
        public int[] RoomIds { get; set;} = new int[0];
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
