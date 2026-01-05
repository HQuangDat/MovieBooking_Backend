using MovieBooking_Backend.Data;

namespace MovieBooking_Backend.Services.Seat
{
    public class SeatService : ISeatService
    {
        private readonly ApplicationDbContext _context;

        public SeatService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
