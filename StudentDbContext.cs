using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace assignment_2;

public partial class StudentDbContext : DbContext
{
  public StudentDbContext()
  {
  }

  public StudentDbContext(DbContextOptions<StudentDbContext> options)
      : base(options)
  {
  }

  public virtual DbSet<Student> Students { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
      => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentDB;Trusted_Connection=True;");

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Student>(entity =>
    {
      entity.HasKey(e => e.Id).HasName("PK__Students__3213E83F758C42C9");

      entity.Property(e => e.Id).HasColumnName("id");
      entity.Property(e => e.Country)
              .HasMaxLength(50)
              .IsUnicode(false)
              .HasColumnName("country");
      entity.Property(e => e.EmailAddress)
              .HasMaxLength(50)
              .IsUnicode(false)
              .HasColumnName("email_address");
      entity.Property(e => e.FirstName)
              .HasMaxLength(50)
              .IsUnicode(false)
              .HasColumnName("first_name");
      entity.Property(e => e.LastName)
              .HasMaxLength(50)
              .IsUnicode(false)
              .HasColumnName("last_name");
      entity.Property(e => e.PhoneNumber)
              .HasMaxLength(50)
              .IsUnicode(false)
              .HasColumnName("phone_number");
    });

    OnModelCreatingPartial(modelBuilder);
  }

  partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
