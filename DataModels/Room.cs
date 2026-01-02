using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.DataModels;

[Table("Room")]
[Index("CinemaId", Name = "IX_Room_CinemaId")]
public partial class Room
{
    [Key]
    public int Id { get; set; }

    public int CinemaId { get; set; }

    [StringLength(50)]
    public string Name { get; set; } = null!;

    [StringLength(20)]
    public string Type { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    [ForeignKey("CinemaId")]
    [InverseProperty("Rooms")]
    public virtual Cinema Cinema { get; set; } = null!;

    [InverseProperty("Room")]
    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    [InverseProperty("Room")]
    public virtual ICollection<Showtime> Showtimes { get; set; } = new List<Showtime>();
}
