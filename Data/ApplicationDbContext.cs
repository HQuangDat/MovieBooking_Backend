using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MovieBooking_Backend.DataModels;

namespace MovieBooking_Backend.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<BookingProduct> BookingProducts { get; set; }

    public virtual DbSet<Cinema> Cinemas { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Seat> Seats { get; set; }

    public virtual DbSet<Showtime> Showtimes { get; set; }

    public virtual DbSet<ShowtimeSeat> ShowtimeSeats { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<User> Users { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AI");

        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Booking__3214EC07788EB4F7");

            entity.Property(e => e.BookingTime).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Showtime).WithMany(p => p.Bookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Booking_Showtime");

            entity.HasOne(d => d.User).WithMany(p => p.Bookings)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Booking_User");
        });

        modelBuilder.Entity<BookingProduct>(entity =>
        {
            entity.HasOne(d => d.Booking).WithMany(p => p.BookingProducts).HasConstraintName("FK_BookingProduct_Booking");

            entity.HasOne(d => d.Product).WithMany(p => p.BookingProducts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BookingProduct_Product");
        });

        modelBuilder.Entity<Cinema>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cinema__3214EC07AB20AF9B");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Movie__3214EC07AA2879C9");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Product__3214EC07DFCB553F");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3214EC07539AA61D");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Room__3214EC07004C9AF2");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);

            entity.HasOne(d => d.Cinema).WithMany(p => p.Rooms).HasConstraintName("FK_Room_Cinema");
        });

        modelBuilder.Entity<Seat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Seat__3214EC07E0F3A77D");

            entity.HasOne(d => d.Room).WithMany(p => p.Seats).HasConstraintName("FK_Seat_Room");
        });

        modelBuilder.Entity<Showtime>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Showtime__3214EC071037F563");

            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.Status).HasDefaultValue("Active");

            entity.HasOne(d => d.Movie).WithMany(p => p.Showtimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Showtime_Movie");

            entity.HasOne(d => d.Room).WithMany(p => p.Showtimes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Showtime_Room");
        });

        modelBuilder.Entity<ShowtimeSeat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Showtime__3214EC07EBD82AE3");

            entity.Property(e => e.Status).HasDefaultValue("Available");

            entity.HasOne(d => d.Seat).WithMany(p => p.ShowtimeSeats)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ShowtimeSeat_Seat");

            entity.HasOne(d => d.Showtime).WithMany(p => p.ShowtimeSeats).HasConstraintName("FK_ShowtimeSeat_Showtime");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ticket__3214EC07825EE6FC");

            entity.HasOne(d => d.Booking).WithMany(p => p.Tickets).HasConstraintName("FK_Ticket_Booking");

            entity.HasOne(d => d.Seat).WithMany(p => p.Tickets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ticket_Seat");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC07D8C429E3");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.MembershipLevel).HasDefaultValue("Standard");
            entity.Property(e => e.Points).HasDefaultValue(0);

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
