using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.DataModels;

[Table("ShowtimeSeat")]
[Index("Status", Name = "IX_ShowtimeSeat_Status")]
[Index("ShowtimeId", "SeatId", Name = "UQ_Showtime_Seat", IsUnique = true)]
public partial class ShowtimeSeat
{
    [Key]
    public int Id { get; set; }

    public int ShowtimeId { get; set; }

    public int SeatId { get; set; }

    [StringLength(20)]
    public string Status { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [ForeignKey("SeatId")]
    [InverseProperty("ShowtimeSeats")]
    public virtual Seat Seat { get; set; } = null!;

    [ForeignKey("ShowtimeId")]
    [InverseProperty("ShowtimeSeats")]
    public virtual Showtime Showtime { get; set; } = null!;
}
