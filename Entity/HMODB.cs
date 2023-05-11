using Entity.models;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public partial class HMODB : DbContext
    {
        public HMODB()
        {
        }

        public HMODB(DbContextOptions<HMODB> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public virtual DbSet<Member> Members { get; set; }

        public virtual DbSet<CoronaVaccine> CoronaVaccines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=HMODB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Member>(entity =>
            {
                entity.ToTable("member");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("Id");

                entity.Property(e => e.IdCard)
                    .HasColumnName("IdCard")
                    .IsRequired()
                    .HasMaxLength(9);

                entity.Property(e => e.FirstName)
                    .HasColumnName("FirstName")
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LastName)
                    .HasColumnName("LastName")
                    .IsRequired()
                    .HasMaxLength(30);

               
                entity.Property(e => e.Email)
                    .HasColumnName("Email");

                entity.Property(e => e.City)
                    .HasColumnName("City")
                    .HasMaxLength(30);

                entity.Property(e => e.Street)
                    .HasColumnName("Street");

                entity.Property(e => e.StreetNumber)
                    .HasColumnName("StreetNumber")
                    .HasMaxLength(3);

                entity.Property(e => e.Phone)
                    .HasColumnName("Phone")
                    .HasMaxLength(10);

                entity.Property(e => e.CellPhone)
                    .HasColumnName("CellPhone")
                    .HasMaxLength(10);

                entity.Property(e => e.Picture)
                    .HasColumnName("Picture");

                entity.Property(e => e.PositiveResultDate)
                    .HasColumnName("PositiveResultDate")
                    .IsRequired();

                entity.Property(e => e.RecoveryDate)
                    .HasColumnName("RecoveryDate")
                    .IsRequired();

            });

            modelBuilder.Entity<CoronaVaccine>(entity =>
            {
                entity.ToTable("coronaVaccine");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Date)
                    .HasColumnName("Date")
                    .IsRequired();

                entity.Property(e => e.ManuFacturer)
                    .HasColumnName("ManuFacturer")
                    .IsRequired();

                entity.Property(e => e.IdCard)
                    .HasColumnName("IdCard")
                    .IsRequired()
                    .HasMaxLength(9);

                entity.HasOne(e => e.Member)
                     .WithMany(e => e.CoronaVaccinesList)
                     .HasForeignKey(e => e.IdCard) // use IdCard as foreign key
                     .HasPrincipalKey(e => e.IdCard); // specify the principal key
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
