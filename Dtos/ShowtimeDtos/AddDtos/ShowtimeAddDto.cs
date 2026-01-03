using System;
using System.ComponentModel.DataAnnotations;

namespace MovieBooking_Backend.Dtos.ShowtimeDtos.AddDtos
{
    public class ShowtimeAddDto
    {
        public int MovieId { get; set; }

        public int RoomId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        [StringLength(20)]
        public string? Status { get; set; }
    }
}
