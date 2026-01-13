using Gridify;
using Microsoft.OpenApi.MicrosoftExtensions;
using MovieBooking_Backend.Data;
using MovieBooking_Backend.Dtos.MovieDtos.AddDtos;
using MovieBooking_Backend.Dtos.MovieDtos.GetDtos;
using MovieBooking_Backend.Dtos.MovieDtos.UpdateDtos;

namespace MovieBooking_Backend.Services.Movie
{
    public interface IMovieService
    {
        Task<Paging<MovieListDto>> GetMovieList(GridifyQuery model);
        Task<MovieDetailsDto> GetMovieByIdAsync(int id);
        Task AddNewMovieAsync(MovieAddDto dto);
        Task UpdateMovieAsync(int id, MovieUpdateDto dto);
        Task DeleteMovie(int id);
    }
}
