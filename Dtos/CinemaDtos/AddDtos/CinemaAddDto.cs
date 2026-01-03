using System.ComponentModel.DataAnnotations;

namespace MovieBooking_Backend.Dtos.CinemaDtos.AddDtos
{
    public class CinemaAddDto
    {
        [StringLength(100)]
        public string Name { get; set; } = null!;

        [StringLength(255)]
        public string Address { get; set; } = null!;

        [StringLength(50)]
        public string City { get; set; } = null!;
    }
}
