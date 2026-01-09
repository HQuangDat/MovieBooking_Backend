namespace MovieBooking_Backend.Dtos.ShowtimeSeatDtos.GetDtos
{
    public class ShowtimeSeatListDto
    {
        public int Id { get; set; }
        public int ShowtimeId { get; set; }
        public int SeatId { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
    }
}
