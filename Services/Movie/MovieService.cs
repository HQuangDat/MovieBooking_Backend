using Gridify;
using Gridify.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MovieBooking_Backend.Data;
using MovieBooking_Backend.Dtos.MovieDtos.AddDtos;
using MovieBooking_Backend.Dtos.MovieDtos.GetDtos;
using MovieBooking_Backend.Dtos.MovieDtos.UpdateDtos;
using MovieBooking_Backend.Dtos.ShowtimeDtos.GetDtos;
using System.Reflection;

namespace MovieBooking_Backend.Services.Movie
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddNewMovieAsync(MovieAddDto dto)
        {
            var newMovie = new DataModels.Movie
            {
                Title = dto.Title,
                Description = dto.Description,
                Director = dto.Director,
                Cast = dto.Cast,
                DurationMinutes = dto.DurationMinutes,
                ReleaseDate = dto.ReleaseDate,
                PosterUrl = dto.PosterUrl,
                TrailerUrl = dto.TrailerUrl
            };
            await _context.Movies.AddAsync(newMovie);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Movie not found");
            }
        }

        public async Task<MovieDetailsDto> GetMovieByIdAsync(int id)
        {
            var movie = await _context.Movies
                                             .AsNoTracking()
                                             .Where(m => m.Id == id)
                                             .Select(m => new MovieDetailsDto
                                             {
                                                 Id = m.Id,
                                                 Title = m.Title,
                                                 Description = m.Description,
                                                 Director = m.Director,
                                                 Cast = m.Cast,
                                                 DurationMinutes = m.DurationMinutes,
                                                 ReleaseDate = m.ReleaseDate,
                                                 PosterUrl = m.PosterUrl,
                                                 TrailerUrl = m.TrailerUrl
                                             }).FirstOrDefaultAsync();
            if (movie == null)
                throw new Exception("No movie with that name found");
            return movie;
        }

        public async Task<Paging<MovieListDto>> GetMovieList(GridifyQuery query)
        {
            var MovieQuery = _context.Movies
                                        .AsNoTracking()
                                        .Select(m => new MovieListDto
                                        {
                                            Id = m.Id,
                                            Title = m.Title,
                                            DurationMinutes = m.DurationMinutes,
                                            PosterUrl = m.PosterUrl
                                        }).GridifyAsync(query);

            return await MovieQuery;
        }

        public async Task UpdateMovieAsync(int id, MovieUpdateDto dto)
        {
            var existingMovie = await _context.Movies.FindAsync(id);
            if(existingMovie == null)
            {
                throw new Exception("Movie not found");
            }
            existingMovie.Title = dto.Title;
            existingMovie.Description = dto.Description;
            existingMovie.Director = dto.Director;
            existingMovie.Cast = dto.Cast;
            existingMovie.DurationMinutes = dto.DurationMinutes;
            existingMovie.ReleaseDate = dto.ReleaseDate;
            existingMovie.PosterUrl = dto.PosterUrl;
            existingMovie.TrailerUrl = dto.TrailerUrl;
            await _context.SaveChangesAsync();
        }
    }
}
