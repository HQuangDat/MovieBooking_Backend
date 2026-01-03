using System.ComponentModel.DataAnnotations.Schema;

namespace MovieBooking_Backend.Dtos.TicketDtos.AddDtos
{
    public class TicketAddDto
    {
        public int BookingId { get; set; }

        public int SeatId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
