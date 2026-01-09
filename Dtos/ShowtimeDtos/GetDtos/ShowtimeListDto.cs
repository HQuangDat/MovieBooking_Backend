namespace MovieBooking_Backend.Dtos.ShowtimeDtos.GetDtos
{
    public class ShowtimeListDto
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int RoomId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
    }
}
