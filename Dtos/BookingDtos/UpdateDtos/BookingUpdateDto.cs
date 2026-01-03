using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.Dtos.BookingDtos.UpdateDtos
{
    public class BookingUpdateDto
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ShowtimeId { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalAmount { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = null!;

        [StringLength(50)]
        public string? PaymentMethod { get; set; }
    }
}
