﻿// <auto-generated />
using System;
using Ahunter_Final_CIDM3312.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AhunterFinalCIDM3312.Migrations
{
    [DbContext(typeof(OrgProjDbContext))]
    partial class OrgProjDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Ahunter_Final_CIDM3312.Models.Organization", b =>
                {
                    b.Property<int>("OrganizationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.HasKey("OrganizationID");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Ahunter_Final_CIDM3312.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("TEXT");

                    b.Property<int>("OrganizationID")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProjectId");

                    b.HasIndex("OrganizationID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Ahunter_Final_CIDM3312.Models.Project", b =>
                {
                    b.HasOne("Ahunter_Final_CIDM3312.Models.Organization", "Organization")
                        .WithMany("Projects")
                        .HasForeignKey("OrganizationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Ahunter_Final_CIDM3312.Models.Organization", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
