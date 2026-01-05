using MovieBooking_Backend.Data;

namespace MovieBooking_Backend.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly ApplicationDbContext _context;

        public RoomService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
