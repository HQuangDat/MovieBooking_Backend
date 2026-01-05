using MovieBooking_Backend.Data;

namespace MovieBooking_Backend.Services.Movie
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
