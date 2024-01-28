using HotelReservationSystem.Models;
using HotelReservationSystem.Models.Request;
using HotelReservationSystem.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelReservationSystem.Controllers
{
    [Route("api/reservations")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        public ReservationController(AppDbContext context, ILogger<ReservationController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // POST api/<ReservationController>
        [HttpPost]
        public ActionResult<RoomReservationResponse> Post([FromBody] RoomReservationRequest reservationRequest)
        {
            _logger.LogInformation("Request Body: {checkInDate}", reservationRequest.CheckInDate);
            var guest = new Guest {
                FirstName = reservationRequest.Guest.FirstName,
                LastName = reservationRequest.Guest.LastName,
                Address = reservationRequest.Guest.Address,
                Phone = reservationRequest.Guest.Phone,
                Email = reservationRequest.Guest.Email,
                CreatedAt = DateTime.UtcNow,
            };

            var roomIds = reservationRequest.RoomIds;
            var discountPercent = roomIds.Length >= 3 ? 5 : 0;


            _context.Guests.Add(guest);
            _context.SaveChanges();

            var dateDifference = reservationRequest.CheckOutDate - reservationRequest.CheckInDate;
            var days = dateDifference.Days;
            var subTotal = reservationRequest.RoomIds.Sum(r => GetRoomRate(r));
            var discountAmount = (subTotal * discountPercent / 100);
            var netAmount = subTotal - discountAmount;

            var reservation = new Reservation
            {
                CheckInDate = reservationRequest.CheckInDate,
                CheckOutDate = reservationRequest.CheckOutDate,
                GuestId = guest.Id,
                SubTotal = subTotal,
                DiscountPercent = discountPercent,
                DiscountAmount = discountAmount,
                NetTotal = netAmount,
                CreatedAt = DateTime.UtcNow,
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            var reservedRooms = new List<RoomReserved>();

            foreach (var roomId in reservationRequest.RoomIds)
            {
                var room = _context.Rooms.FirstOrDefault(r => r.Id == roomId);
                if (room != null)
                {
                    var reservedRoom = new RoomReserved
                    {
                        RoomID = room.Id,
                        RoomType = room.RoomType,
                        RatePerNight = room.RatePerNight,
                        ReservationId = reservation.Id,
                        CreatedAt = DateTime.UtcNow
                    };

                    _context.RoomsReserved.Add(reservedRoom);
                    _context.SaveChanges();

                    reservedRooms.Add(reservedRoom);
                }
            }

            var response = new RoomReservationResponse
            {
                ReservationId = reservation.Id,
                Guest = guest,
                RoomReserved = reservedRooms.Select(rr => new RoomReserved 
                { 
                    Id = rr.Id,
                    RoomID = rr.RoomID,
                    RoomType=rr.RoomType,
                    RatePerNight=rr.RatePerNight,
                    ReservationId = reservation.Id,
                    CreatedAt = rr.CreatedAt
                }).ToList(),
                CheckInDate = reservation.CheckInDate,
                CheckOutDate = reservation.CheckOutDate,
                Days = days,
                DiscountPercent = reservation.DiscountPercent,
                DiscountAmount = reservation.DiscountAmount,
                SubTotal = reservation.SubTotal,
                NetTotal = netAmount,
            };

            return Ok(response);
        }

        private decimal GetRoomRate(int roomId)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == roomId);

            return room?.RatePerNight ?? 0;
        }
    }
}
