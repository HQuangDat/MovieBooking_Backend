using MovieBooking_Backend.Data;

namespace MovieBooking_Backend.Services.Cinema
{
    public class CinemaService : ICinemaService
    {
        private readonly ApplicationDbContext _context;

        public CinemaService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
