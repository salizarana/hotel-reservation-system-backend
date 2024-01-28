namespace HotelReservationSystem.Models.Response
{
    public class RoomReservationResponse
    {
        public int ReservationId { get; set; }
        public Guest Guest { get; set;}
        public List<RoomReserved> RoomReserved { get; set;}
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Days { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal SubTotal { get; set; }
        public decimal NetTotal { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
