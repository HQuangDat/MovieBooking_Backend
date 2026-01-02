using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.DataModels;

[Table("Seat")]
[Index("RoomId", "RowCode", "SeatNumber", Name = "UQ_Seat_Room_Position", IsUnique = true)]
public partial class Seat
{
    [Key]
    public int Id { get; set; }

    public int RoomId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string RowCode { get; set; } = null!;

    public int SeatNumber { get; set; }

    [StringLength(20)]
    public string Type { get; set; } = null!;

    [ForeignKey("RoomId")]
    [InverseProperty("Seats")]
    public virtual Room Room { get; set; } = null!;

    [InverseProperty("Seat")]
    public virtual ICollection<ShowtimeSeat> ShowtimeSeats { get; set; } = new List<ShowtimeSeat>();

    [InverseProperty("Seat")]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
