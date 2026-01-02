using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.DataModels;

[Table("Ticket")]
[Index("BookingId", Name = "IX_Ticket_BookingId")]
public partial class Ticket
{
    [Key]
    public int Id { get; set; }

    public int BookingId { get; set; }

    public int SeatId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    [ForeignKey("BookingId")]
    [InverseProperty("Tickets")]
    public virtual Booking Booking { get; set; } = null!;

    [ForeignKey("SeatId")]
    [InverseProperty("Tickets")]
    public virtual Seat Seat { get; set; } = null!;
}
