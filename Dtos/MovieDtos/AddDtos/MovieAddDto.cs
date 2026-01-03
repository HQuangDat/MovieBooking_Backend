using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.Dtos.MovieDtos.AddDtos
{
    public class MovieAddDto
    {
        [StringLength(200)]
        public string Title { get; set; } = null!;

        public string? Description { get; set; }

        [StringLength(100)]
        public string? Director { get; set; }

        public string? Cast { get; set; }

        public int DurationMinutes { get; set; }

        public DateOnly ReleaseDate { get; set; }

        [StringLength(500)]
        [Unicode(false)]
        public string? PosterUrl { get; set; }

        [StringLength(500)]
        [Unicode(false)]
        public string? TrailerUrl { get; set; }
    }
}
