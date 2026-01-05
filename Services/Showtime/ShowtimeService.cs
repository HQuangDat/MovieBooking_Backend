using MovieBooking_Backend.Data;

namespace MovieBooking_Backend.Services.Showtime
{
    public class ShowtimeService : IShowtimeService
    {
        private readonly ApplicationDbContext _context;

        public ShowtimeService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
