using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking_Backend.DataModels;

[Table("Cinema")]
[Index("City", Name = "IX_Cinema_City")]
public partial class Cinema
{
    [Key]
    public int Id { get; set; }

    [StringLength(100)]
    public string Name { get; set; } = null!;

    [StringLength(255)]
    public string Address { get; set; } = null!;

    [StringLength(50)]
    public string City { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    [InverseProperty("Cinema")]
    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
