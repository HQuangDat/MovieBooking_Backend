using Gridify;
using MovieBooking_Backend.Dtos.CinemaDtos.AddDtos;
using MovieBooking_Backend.Dtos.CinemaDtos.GetDtos;
using MovieBooking_Backend.Dtos.CinemaDtos.UpdateDtos;

namespace MovieBooking_Backend.Services.Cinema
{
    public interface ICinemaService
    {
        Task<Paging<CinemaListDto>> GetCinemaList(GridifyQuery model);
        Task<CinemaDetailsDto> GetCinemaByIdAsync(int id);
        Task AddNewCinemaAsync(CinemaAddDto dto);
        Task UpdateCinemaAsync(int id, CinemaUpdateDto dto);
        Task DeleteCinema(int id);
    }
}
