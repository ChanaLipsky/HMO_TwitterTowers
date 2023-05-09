using Entity.models;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

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

                entity.Property(e => e.Id)
                    .HasColumnName("Id")
                    //איך כותבים שיהיה מס' יחודי רץ
                    ;

                entity.Property(e => e.IdCard)
                    .HasColumnName("IdCard")
                    .IsRequired()
                    .HasMaxLength(9)
                    //.IsFixedLength(9)-אי עושים שיהיה לפחות 9 ספרות
                    ;

                entity.Property(e => e.FirstName)                    
                    .HasColumnName("FirstName")
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastName)
                    .HasColumnName("LastName")
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasColumnName("Email")
                    //איך עושים שיכתב פה דוקא מייל
                    ;

                entity.Property(e => e.City)
                    .HasColumnName("City")
                    .HasMaxLength(30);

                entity.Property(e => e.Street)
                    .HasColumnName("Street");

                entity.Property(e => e.StreetNumber)
                    .HasColumnName("StreetNumber")
                    .HasMaxLength(3); 

                entity.Property(e => e.Phone)
                    .HasColumnName("Phone");

                entity.Property(e => e.CellPhone)
                    .HasColumnName("CellPhone");

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

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Date)   
                    .HasColumnName("Date")
                    .IsRequired();

                entity.Property(e => e.ManuFacturer)
                    .HasColumnName("ManuFacturer")
                    .IsRequired();

            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}

