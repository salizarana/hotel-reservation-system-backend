using System.ComponentModel.DataAnnotations;

namespace HotelReservationSystem.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        public required string Email { get; set; }
        public string Phone {  get; set; }
        public required string Address { get; set; }
        public string? Details { get; set; }
        public DateTime? CreatedAt { get; set;}
    }
}
