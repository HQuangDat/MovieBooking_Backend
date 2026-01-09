namespace MovieBooking_Backend.Dtos.TicketDtos.GetDtos
{
    public class TicketDetailsDto
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public int SeatId { get; set; }
        public decimal Price { get; set; }
    }
}
