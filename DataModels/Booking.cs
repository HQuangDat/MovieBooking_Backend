using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.DataModels;

[Table("Booking")]
[Index("ShowtimeId", Name = "IX_Booking_ShowtimeId")]
[Index("UserId", Name = "IX_Booking_UserId")]
public partial class Booking
{
    [Key]
    public int Id { get; set; }

    public int UserId { get; set; }

    public int ShowtimeId { get; set; }

    public DateTime? BookingTime { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal TotalAmount { get; set; }

    [StringLength(20)]
    public string Status { get; set; } = null!;

    [StringLength(50)]
    public string? PaymentMethod { get; set; }

    [InverseProperty("Booking")]
    public virtual ICollection<BookingProduct> BookingProducts { get; set; } = new List<BookingProduct>();

    [ForeignKey("ShowtimeId")]
    [InverseProperty("Bookings")]
    public virtual Showtime Showtime { get; set; } = null!;

    [InverseProperty("Booking")]
    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();

    [ForeignKey("UserId")]
    [InverseProperty("Bookings")]
    public virtual User User { get; set; } = null!;
}
