namespace MovieBooking_Backend.Dtos.RoomDtos.GetDtos
{
    public class RoomDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CinemaId { get; set; }
    }
}
