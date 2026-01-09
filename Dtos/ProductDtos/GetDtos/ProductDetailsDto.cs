namespace MovieBooking_Backend.Dtos.ProductDtos.GetDtos
{
    public class ProductDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
    }
}
