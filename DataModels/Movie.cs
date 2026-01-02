using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.DataModels;

[Table("Movie")]
[Index("Title", Name = "IX_Movie_Title")]
public partial class Movie
{
    [Key]
    public int Id { get; set; }

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

    public bool? IsDeleted { get; set; }

    [InverseProperty("Movie")]
    public virtual ICollection<Showtime> Showtimes { get; set; } = new List<Showtime>();
}
