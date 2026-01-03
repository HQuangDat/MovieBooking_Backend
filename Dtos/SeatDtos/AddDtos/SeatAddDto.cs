using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.Dtos.SeatDtos.AddDtos
{
    public class SeatAddDto
    {
        public int RoomId { get; set; }

        [StringLength(5)]
        [Unicode(false)]
        public string RowCode { get; set; } = null!;

        public int SeatNumber { get; set; }

        [StringLength(20)]
        public string Type { get; set; } = null!;
    }
}
