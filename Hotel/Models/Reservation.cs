using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Hotel.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? CustomerName { get; set; }

        public int NumberOfDays { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
