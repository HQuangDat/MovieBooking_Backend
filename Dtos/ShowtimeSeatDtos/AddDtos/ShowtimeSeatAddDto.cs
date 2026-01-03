using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieBooking_Backend.Dtos.ShowtimeSeatDtos.AddDtos
{
    public class ShowtimeSeatAddDto
    {
        public int ShowtimeId { get; set; }

        public int SeatId { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = null!;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
