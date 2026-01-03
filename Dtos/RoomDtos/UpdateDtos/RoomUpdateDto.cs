using System.ComponentModel.DataAnnotations;

namespace MovieBooking_Backend.Dtos.RoomDtos.UpdateDtos
{
    public class RoomUpdateDto
    {
        public int Id { get; set; }

        public int CinemaId { get; set; }

        [StringLength(50)]
        public string Name { get; set; } = null!;

        [StringLength(20)]
        public string Type { get; set; } = null!;

        public bool? IsDeleted { get; set; }
    }
}
