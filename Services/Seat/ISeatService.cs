using Gridify;
using MovieBooking_Backend.Data;
using MovieBooking_Backend.Dtos.SeatDtos.AddDtos;
using MovieBooking_Backend.Dtos.SeatDtos.GetDtos;
using MovieBooking_Backend.Dtos.SeatDtos.UpdateDtos;

namespace MovieBooking_Backend.Services.Seat
{
    public interface ISeatService
    {
        Task<Paging<SeatListDto>> GetAllSeatsAsync(GridifyQuery model);
        Task<SeatDetailsDto> GetSeatById(int id);
        Task AddNewSeat(SeatAddDto dto);
        Task EditSeatAsync(int id, SeatUpdateDto dto);
        Task DeleteSeatAsync(int id);
    }
}
