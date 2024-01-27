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
                    Description = "Introducing our cozy single room, thoughtfully designed for comfort and convenience. Ideal for solo travelers, our well-appointed room features a comfortable bed, modern furnishings, and a private en-suite bathroom. Enjoy a restful night's sleep and wake up refreshed to explore the nearby attractions.",
                    Features = ["TV", "Attach Bathroom"],
                    Photos = ["https://img.freepik.com/free-photo/luxury-bedroom-hotel_1150-10836.jpg?w=996&t=st=1706376938~exp=1706377538~hmac=627ece7cca4fc483886761ab27c78ee5c6de1d0f1c2ace85a69eb48a9b1270e0"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 2,
                    RoomType = "Double Room",
                    RoomNumber = "102",
                    Capacity = 2,
                    RatePerNight = 1200,
                    Description = "Discover comfort and style in our inviting double room, perfect for couples or those desiring extra space. The room is equipped with all the essentials, including a private en-suite bathroom and thoughtful amenities.",
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
                    Description = "Indulge in the comfort of our twin room, tailored for those traveling with a friend or family member. This well-designed space features two comfortable single beds and a charming ambiance. With modern furnishings and a private en-suite bathroom, our twin room provides a harmonious blend of style and functionality. ",
                    Features = ["AC", "Smart TV"],
                    Photos = ["https://images.unsplash.com/photo-1648383228240-6ed939727ad6?q=80&w=1974&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 4,
                    RoomType = "Double Room",
                    RoomNumber = "201",
                    Capacity = 2,
                    RatePerNight = 1500,
                    Description = "Elevate your stay in our exquisite double room with a view, where comfort meets breathtaking scenery. Unwind in a stylish space featuring a luxurious double bed, modern decor, and expansive windows that offer stunning views of the surroundings. ",
                    Features = ["AC", "TV", "Balcony"],
                    Photos = ["https://img.freepik.com/free-photo/luxury-bedroom-interior-with-rich-furniture-scenic-view-from-walkout-deck_1258-111480.jpg?w=826&t=st=1706377687~exp=1706378287~hmac=2981f070e3f562c4a1c7bb505187d5ca12aad1fc554e7abc22362f852f7be28f"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 5,
                    RoomType = "Single Room",
                    RoomNumber = "202",
                    Capacity = 1,
                    RatePerNight = 700,
                    Description = "Experience convenience and productivity in our well-designed single room with a dedicated working table. Ideal for solo travelers on business or leisure, this room offers a comfortable single bed, modern decor, and a thoughtfully arranged workspace.",
                    Features = ["AC", "TV", "Working Table"],
                    Photos = ["https://img.freepik.com/free-photo/3d-rendering-beautiful-luxury-bedroom-suite-hotel-with-working-table_105762-2154.jpg?w=996&t=st=1706377878~exp=1706378478~hmac=5d44a19e84fcdcfb667371ff4f6e93773f769cf56f34151abd9a88ff2cfd688d"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 6,
                    RoomType = "Single Room",
                    RoomNumber = "203",
                    Capacity = 1,
                    RatePerNight = 850,
                    Description = "Escape to serenity in our charming single room with a private balcony. Unwind in a cozy space designed for solo travelers, complete with a comfortable bed and modern amenities.",
                    Features = ["AC", "Smart TV", "Balcony"],
                    Photos = ["https://img.freepik.com/free-photo/pillow-bed_74190-4497.jpg?w=996&t=st=1706378050~exp=1706378650~hmac=e60192a5e52f40232073b1bb8ce16bae65d144d1ce8cec80559f71c069f50a4c"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 7,
                    RoomType = "Suite Room",
                    RoomNumber = "204",
                    Capacity = 4,
                    RatePerNight = 3500,
                    Description = "Indulge in luxury and sophistication with our elegantly appointed suite room. Perfect for those seeking an extra level of comfort, our suite features a spacious living area, a well-appointed bedroom with a plush king-size bed, and a stylish en-suite bathroom. ",
                    Features = ["AC", "Smart TV", "Balcony", "Hot Tub"],
                    Photos = ["https://img.freepik.com/free-photo/3d-rendering-modern-luxury-bedroom-suite-bathroom_105762-1945.jpg?w=900&t=st=1706378163~exp=1706378763~hmac=1bf3f85aeb78a0b69a3c75514d67db3f897314bdd5a863f5ddf777a1e92758bf"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 8,
                    RoomType = "Deluxe Room",
                    RoomNumber = "205",
                    Capacity = 3,
                    RatePerNight = 3000,
                    Description = "Experience the epitome of comfort and luxury in our deluxe room with a private lounge. Unwind in style with a spacious and beautifully decorated bedroom, featuring a luxurious king-size bed. ",
                    Features = ["AC", "Smart TV", "Balcony", "Hot Tub"],
                    Photos = ["https://img.freepik.com/free-photo/luxury-bedroom-suite-resort-high-rise-hotel-with-working-table_105762-1783.jpg?w=900&t=st=1706378619~exp=1706379219~hmac=f2fe9538a01f68663d95d6bc37fcbe4d158d69356b8934b468fc856790311fb3"],
                    CreatedAt = DateTime.Now,
                },
                new Room
                {
                    Id = 9,
                    RoomType = "Double Room",
                    RoomNumber = "206",
                    Capacity = 2,
                    RatePerNight = 2500,
                    Description = "Escape to tranquility in our cozy room with a picturesque view of lush greenery. Nestled in a serene environment, this thoughtfully designed space offers a comfortable retreat with a cozy bed and modern amenities.",
                    Features = ["AC", "Smart TV", "Hot Tub"],
                    Photos = ["https://img.freepik.com/free-photo/chair-sits-cabinstyle-bedroom_157027-4296.jpg?w=1060&t=st=1706378980~exp=1706379580~hmac=75cec97c1b06333344d8b4725aec3c92d8af42c191797a18df754d68101921b0"],
                    CreatedAt = DateTime.Now,
                }
            };

            foreach (var room in rooms)
                dbContext.Rooms.Add(room);

            dbContext.SaveChanges();
        }
    }
}
