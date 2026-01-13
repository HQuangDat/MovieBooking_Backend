using Gridify;
using MovieBooking_Backend.Data;
using MovieBooking_Backend.Dtos.ProductDtos.AddDtos;
using MovieBooking_Backend.Dtos.ProductDtos.GetDtos;
using MovieBooking_Backend.Dtos.ProductDtos.UpdateDtos;

namespace MovieBooking_Backend.Services.Product
{
    public interface IProductService
    {
        Task<Paging<ProductListDto>> GetAllProductsAsync(GridifyQuery model);
        Task<ProductDetailsDto> GetProductByIdAsync(int id);
        Task AddNewProductAsync(ProductAddDto dto);
        Task UpdateProductAsync(int id, ProductUpdateDto dto);
        Task DeleteProduct(int id);
    }
}
