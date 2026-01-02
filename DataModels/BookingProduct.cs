using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.DataModels;

[PrimaryKey("BookingId", "ProductId")]
[Table("BookingProduct")]
public partial class BookingProduct
{
    [Key]
    public int BookingId { get; set; }

    [Key]
    public int ProductId { get; set; }

    public int Quantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal UnitPrice { get; set; }

    [ForeignKey("BookingId")]
    [InverseProperty("BookingProducts")]
    public virtual Booking Booking { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("BookingProducts")]
    public virtual Product Product { get; set; } = null!;
}
