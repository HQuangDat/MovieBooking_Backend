using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.Dtos.UserDtos.AddDtos
{
    public class UserAddDto
    {
        public int RoleId { get; set; }

        [StringLength(50)]
        [Unicode(false)]
        public string Username { get; set; } = null!;

        [StringLength(100)]
        public string FullName { get; set; } = null!;

        [StringLength(100)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [StringLength(20)]
        [Unicode(false)]
        public string? PhoneNumber { get; set; }

        public int? Points { get; set; }

        [StringLength(20)]
        public string? MembershipLevel { get; set; }
    }
}
