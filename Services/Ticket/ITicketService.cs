using Gridify;
using MovieBooking_Backend.Data;
using MovieBooking_Backend.Dtos.TicketDtos.AddDtos;
using MovieBooking_Backend.Dtos.TicketDtos.GetDtos;
using MovieBooking_Backend.Dtos.TicketDtos.UpdateDtos;

namespace MovieBooking_Backend.Services.Ticket
{
    public interface ITicketService
    {
        Task<Paging<TicketListDto>> GetAllTicketsAsync(GridifyQuery model);
        Task<TicketDetailsDto> GetTicketByIdAsync(int id);
        Task AddNewTicketAsync(TicketAddDto dto);
        Task UpdateTicketAsync(int id, TicketUpdateDto dto);
        Task DeleteTicketAsync(int id); 
    }
}
