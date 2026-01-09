using Gridify;
using Microsoft.OpenApi.MicrosoftExtensions;
using MovieBooking_Backend.Data;

namespace MovieBooking_Backend.Services.Movie
{
    public interface IMovieService
    {
        Task<Paging<MovieListDto>> getMovies(GridifyQuery model);
    }
}
