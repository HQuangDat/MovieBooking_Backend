using System.ComponentModel.DataAnnotations;

namespace MovieBooking_Backend.Dtos.RoleDtos.UpdateDtos
{
    public class RoleUpdateDto
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string RoleName { get; set; } = null!;

        [StringLength(255)]
        public string? Description { get; set; }
    }
}
