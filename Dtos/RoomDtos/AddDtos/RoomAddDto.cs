using System.ComponentModel.DataAnnotations;

namespace MovieBooking_Backend.Dtos.RoomDtos.AddDtos
{
    public class RoomAddDto
    {
        public int CinemaId { get; set; }

        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(20)]
        public string Type { get; set; } = null!;
    }
}
