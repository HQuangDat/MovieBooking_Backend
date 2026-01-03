using System.ComponentModel.DataAnnotations;

namespace MovieBooking_Backend.Dtos.CinemaDtos.UpdateDtos
{
    public class CinemaUpdateDto
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(255)]
        public string Address { get; set; } = null!;

        [StringLength(50)]
        public string City { get; set; } = null!;

        public bool? IsDeleted { get; set; }
    }
}
