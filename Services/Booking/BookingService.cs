using MovieBooking_Backend.Data;

namespace MovieBooking_Backend.Services.Booking
{
    public class BookingService : IBookingService
    {
        private readonly ApplicationDbContext _context;

        public BookingService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
