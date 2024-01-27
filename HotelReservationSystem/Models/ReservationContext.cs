﻿using Microsoft.EntityFrameworkCore;

namespace HotelReservationSystem.Models
{
    public class ReservationContext: DbContext
    {
        public ReservationContext(DbContextOptions<ReservationContext> options) : base(options) {}

        public DbSet<Reservation> Reservations { get; set; } = null!;
    }
}
