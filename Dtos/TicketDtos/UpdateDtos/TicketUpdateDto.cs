using System.ComponentModel.DataAnnotations.Schema;

namespace MovieBooking_Backend.Dtos.TicketDtos.UpdateDtos
{
    public class TicketUpdateDto
    {
        public int Id { get; set; }

        public int BookingId { get; set; }

        public int SeatId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
