namespace HotelReservationSystem.Models.Response
{
    public class RoomReservationResponse
    {
        public int ReservationId { get; set; }
        public Guest Guest { get; set;}
        public RoomReserved[] RoomReserved { get; set;}
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int DiscountPercent { get; set; }
        public int GrossTotal { get; set; }
        public int NetTotal { get; set; }
    }
}
