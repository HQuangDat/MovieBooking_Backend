namespace MovieBooking_Backend.Dtos.BookingDtos.GetDtos
{
    public class BookingDetailsDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ShowtimeId { get; set; }
        public DateTime? BookingTime { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
