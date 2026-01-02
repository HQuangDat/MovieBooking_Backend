using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.DataModels;

[Table("Showtime")]
[Index("MovieId", Name = "IX_Showtime_MovieId")]
[Index("RoomId", Name = "IX_Showtime_RoomId")]
[Index("StartTime", Name = "IX_Showtime_StartTime")]
public partial class Showtime
{
    [Key]
    public int Id { get; set; }

    public int MovieId { get; set; }

    public int RoomId { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    [StringLength(20)]
    public string? Status { get; set; }

    public bool? IsDeleted { get; set; }

    [InverseProperty("Showtime")]
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    [ForeignKey("MovieId")]
    [InverseProperty("Showtimes")]
    public virtual Movie Movie { get; set; } = null!;

    [ForeignKey("RoomId")]
    [InverseProperty("Showtimes")]
    public virtual Room Room { get; set; } = null!;

    [InverseProperty("Showtime")]
    public virtual ICollection<ShowtimeSeat> ShowtimeSeats { get; set; } = new List<ShowtimeSeat>();
}
