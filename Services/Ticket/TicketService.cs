using MovieBooking_Backend.Data;

namespace MovieBooking_Backend.Services.Ticket
{
    public class TicketService : ITicketService
    {
        private readonly ApplicationDbContext _context;

        public TicketService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
