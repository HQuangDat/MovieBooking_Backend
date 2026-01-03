using System.ComponentModel.DataAnnotations;

namespace MovieBooking_Backend.Dtos.RoleDtos.AddDtos
{
    public class RoleAddDto
    {
        [StringLength(50)]
        public string RoleName { get; set; } = null!;

        [StringLength(255)]
        public string? Description { get; set; }
    }
}
