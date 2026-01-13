using Gridify;
using MovieBooking_Backend.Data;
using MovieBooking_Backend.Dtos.ShowtimeDtos.AddDtos;
using MovieBooking_Backend.Dtos.ShowtimeDtos.GetDtos;
using MovieBooking_Backend.Dtos.ShowtimeDtos.UpdateDtos;

namespace MovieBooking_Backend.Services.Showtime
{
    public interface IShowtimeService
    {
        Task<Paging<ShowtimeListDto>> GetAllShowtimesAsync(GridifyQuery model);
        Task<ShowtimeDetailsDto> GetShowtimeByIdAsync(int id);
        Task AddNewShowtimeAsync(ShowtimeAddDto dto);
        Task UpdateShowtimeAsync(int id, ShowtimeUpdateDto);
        Task DeleteShowtimeAsync(int id);
    }
}
