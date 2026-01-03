using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.Dtos.ProductDtos.UpdateDtos
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [StringLength(255)]
        public string? Description { get; set; }

        [StringLength(500)]
        [Unicode(false)]
        public string? Image { get; set; }

        public bool? IsDeleted { get; set; }
    }
}
