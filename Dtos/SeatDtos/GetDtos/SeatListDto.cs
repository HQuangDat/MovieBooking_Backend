namespace MovieBooking_Backend.Dtos.SeatDtos.GetDtos
{
    public class SeatListDto
    {
        public int Id { get; set; }
        public string RowCode { get; set; }
        public int SeatNumber { get; set; }
        public string Type { get; set; }
        public int RoomId { get; set; }
    }
}
