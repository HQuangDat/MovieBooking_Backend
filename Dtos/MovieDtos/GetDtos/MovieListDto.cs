namespace MovieBooking_Backend.Dtos.MovieDtos.GetDtos
{
    public class MovieListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DurationMinutes { get; set; }
        public string? PosterUrl { get; set; }
    }
}
