using HotelReservationSystem.Models;

namespace HotelReservationSystem
{
    internal class DbInitializer
    {
        internal static void Initialize(RoomContext dbContext)
        {
            ArgumentNullException.ThrowIfNull(dbContext, nameof(dbContext));
            dbContext.Database.EnsureCreated();
            if (dbContext.Rooms.Any()) return;

            var rooms = new Room[]
            {
                new Room
                {
                    Id = 1,
                    RoomType = "Single Room",
                    RoomNumber = "101",
                    Capacity = 1,
                    RatePerNight = 600,
                    Description = "Single Room",
                    Features = ["TV"],
                    Photos = ["https://i.pinimg.com/564x/b7/48/98/b74898796fd9073ebd85ca9a6ce9d8b7.jpg"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 2,
                    RoomType = "Double Room",
                    RoomNumber = "102",
                    Capacity = 2,
                    RatePerNight = 1200,
                    Description = "Double Room",
                    Features = ["AC", "TV"],
                    Photos = ["https://i.pinimg.com/564x/b7/48/98/b74898796fd9073ebd85ca9a6ce9d8b7.jpg"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 3,
                    RoomType = "Twin Room",
                    RoomNumber = "103",
                    Capacity = 2,
                    RatePerNight = 1400,
                    Description = "Twin Room",
                    Features = ["AC", "Smart TV"],
                    Photos = ["https://i.pinimg.com/564x/b7/48/98/b74898796fd9073ebd85ca9a6ce9d8b7.jpg"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 4,
                    RoomType = "Double Room",
                    RoomNumber = "201",
                    Capacity = 2,
                    RatePerNight = 1500,
                    Description = "Double Room",
                    Features = ["AC", "TV", "Balcony"],
                    Photos = ["https://i.pinimg.com/564x/b7/48/98/b74898796fd9073ebd85ca9a6ce9d8b7.jpg"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 5,
                    RoomType = "Single Room",
                    RoomNumber = "202",
                    Capacity = 1,
                    RatePerNight = 700,
                    Description = "Single Room",
                    Features = ["AC", "TV"],
                    Photos = ["https://i.pinimg.com/564x/b7/48/98/b74898796fd9073ebd85ca9a6ce9d8b7.jpg"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 6,
                    RoomType = "Single Room",
                    RoomNumber = "203",
                    Capacity = 1,
                    RatePerNight = 850,
                    Description = "Single Room",
                    Features = ["AC", "Smart TV", "Balcony"],
                    Photos = ["https://i.pinimg.com/564x/b7/48/98/b74898796fd9073ebd85ca9a6ce9d8b7.jpg"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 7,
                    RoomType = "Suite Room",
                    RoomNumber = "204",
                    Capacity = 5,
                    RatePerNight = 3500,
                    Description = "Suite Room",
                    Features = ["AC", "Smart TV", "Balcony", "Hot Tub"],
                    Photos = ["https://i.pinimg.com/564x/b7/48/98/b74898796fd9073ebd85ca9a6ce9d8b7.jpg"],
                    CreatedAt = DateTime.Now,
                }
            };

            foreach (var room in rooms)
                dbContext.Rooms.Add(room);

            dbContext.SaveChanges();
        }
    }
}
