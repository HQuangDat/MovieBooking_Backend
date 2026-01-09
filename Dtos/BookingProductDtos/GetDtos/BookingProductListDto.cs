namespace MovieBooking_Backend.Dtos.BookingProductDtos.GetDtos
{
    public class BookingProductListDto
    {
        public int BookingId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
