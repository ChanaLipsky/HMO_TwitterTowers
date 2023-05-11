﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entity.Migrations
{
    [DbContext(typeof(HMODB))]
    [Migration("20230511120727_AddBirthdateToMember")]
    partial class AddBirthdateToMember
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Entity.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Id");

                    b.Property<string>("CellPhone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnName("CellPhone");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("City");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT")
                        .HasColumnName("DateOfBirth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("FirstName");

                    b.Property<string>("IdCard")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("TEXT")
                        .HasColumnName("IdCard");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT")
                        .HasColumnName("LastName");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT")
                        .HasColumnName("Phone");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Picture");

                    b.Property<DateTime>("PositiveResultDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("PositiveResultDate");

                    b.Property<DateTime>("RecoveryDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("RecoveryDate");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Street");

                    b.Property<int>("StreetNumber")
                        .HasMaxLength(3)
                        .HasColumnType("INTEGER")
                        .HasColumnName("StreetNumber");

                    b.HasKey("Id");

                    b.ToTable("member", null, t =>
                        {
                            t.HasCheckConstraint("DateOfBirth must be before today", "DateOfBirth < date('now')");
                        });
                });

            modelBuilder.Entity("Entity.models.CoronaVaccine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT")
                        .HasColumnName("Date");

                    b.Property<string>("IdCard")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("TEXT")
                        .HasColumnName("IdCard");

                    b.Property<string>("ManuFacturer")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("ManuFacturer");

                    b.HasKey("Id");

                    b.HasIndex("IdCard");

                    b.ToTable("coronaVaccine", (string)null);
                });

            modelBuilder.Entity("Entity.models.CoronaVaccine", b =>
                {
                    b.HasOne("Entity.Models.Member", "Member")
                        .WithMany("CoronaVaccinesList")
                        .HasForeignKey("IdCard")
                        .HasPrincipalKey("IdCard")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Entity.Models.Member", b =>
                {
                    b.Navigation("CoronaVaccinesList");
                });
#pragma warning restore 612, 618
        }
    }
}
