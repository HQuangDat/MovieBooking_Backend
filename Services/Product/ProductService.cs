using MovieBooking_Backend.Data;

namespace MovieBooking_Backend.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
