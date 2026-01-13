using Gridify;
using MovieBooking_Backend.Data;
using MovieBooking_Backend.Dtos.RoomDtos.AddDtos;
using MovieBooking_Backend.Dtos.RoomDtos.GetDtos;
using MovieBooking_Backend.Dtos.RoomDtos.UpdateDtos;

namespace MovieBooking_Backend.Services.Room
{
    public interface IRoomService
    {
        Task<Paging<RoomListDto>> GetAllRoomsAsync(GridifyQuery model);
        Task<RoomDetailsDto> GetRoomByIdAsync(int id);
        Task AddNewRoomAsync(RoomAddDto dto);
        Task UpdateRoomAsync(RoomUpdateDto dto);
        Task DeleteRoomAsync(int id);
    }
}
