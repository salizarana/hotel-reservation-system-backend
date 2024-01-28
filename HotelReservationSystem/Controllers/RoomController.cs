using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HotelReservationSystem.Models;
using Microsoft.OpenApi.Any;

namespace HotelReservationSystem.Controllers
{
    [Route("api/rooms")]
    [ApiController]
    public class RoomController : ControllerBase
    {

        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        public RoomController(AppDbContext context, ILogger<RoomController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // get: api/room
        [HttpGet]
        public ActionResult<Room> GetRooms(DateTime checkInDate, DateTime checkOutDate, int guestCount, int roomCount)
        {
            if (guestCount < 1 || roomCount < 1)
                return BadRequest("Issue with guest count or room count");

            if (checkInDate.Date < DateTime.Today.Date)
                return BadRequest("Issue with check in date.");

            if (checkOutDate.Date < DateTime.Today.AddDays(1).Date)
                return BadRequest("Issue with check out date.");
            //if (guestCount < 1 || roomCount < 1 || checkInDate.Date < DateTime.Today.Date || checkOutDate.Date < DateTime.Today.AddDays(1).Date) {
            //    return BadRequest();
            //}

            var reservedRoomIds = _context.Reservations
                .Where(r => !(r.CheckOutDate <= checkInDate || r.CheckInDate >= checkOutDate))
                .SelectMany(r => _context.RoomsReserved.Where(rr => rr.ReservationId == r.Id))
                .Select(rr => rr.RoomID);

            var availableRooms = _context.Rooms
                .Where(room => !reservedRoomIds.Contains(room.Id));

            var capacity = availableRooms.Sum(r => r.Capacity);

            if (availableRooms.Count() >= roomCount && capacity >= guestCount) {
            
                return Ok(availableRooms);
            }

            _logger.LogInformation("Available Rooms: {availableRooms}", availableRooms.Count());

            return NotFound();
        }
    }
}
