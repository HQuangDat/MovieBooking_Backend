using Gridify;
using MovieBooking_Backend.Data;
using MovieBooking_Backend.Dtos.BookingDtos.AddDtos;
using MovieBooking_Backend.Dtos.BookingDtos.GetDtos;
using MovieBooking_Backend.Dtos.BookingDtos.UpdateDtos;

namespace MovieBooking_Backend.Services.Booking
{
    public interface IBookingService
    {
        Task<Paging<BookingListDto>> GetBookingList(GridifyQuery model);
        Task<BookingDetailsDto> GetBookingByIdAsync(int id);
        Task<bool> IsSeatAvailable(int showtimeId, string seatNumber);
        Task MakeAReservation(BookingAddDto dto);
        Task EditABooking(int bookingId, BookingUpdateDto dto);
        Task CancelReservation(int reservationId);
    }
}
