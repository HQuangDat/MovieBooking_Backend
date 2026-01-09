namespace MovieBooking_Backend.Dtos.MovieDtos.GetDtos
{
    public class MovieDetailsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Director { get; set; }
        public string? Cast { get; set; }
        public int DurationMinutes { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string? PosterUrl { get; set; }
        public string? TrailerUrl { get; set; }
    }
}
