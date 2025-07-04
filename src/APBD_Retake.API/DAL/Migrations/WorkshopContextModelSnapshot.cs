﻿// <auto-generated />
using System;
using APBD_Retake.API.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APBD_Retake.API.DAL.Migrations
{
    [DbContext(typeof(WorkshopContext))]
    partial class WorkshopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APBD_Retake.API.Models.Client", b =>
                {
                    b.Property<int>("Client_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Client_id"));

                    b.Property<DateTime>("Date_of_birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Client_id");

                    b.ToTable("Client", (string)null);
                });

            modelBuilder.Entity("APBD_Retake.API.Models.Mechanic", b =>
                {
                    b.Property<int>("Mechanic_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mechanic_id"));

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Licence_number")
                        .IsRequired()
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("Mechanic_id");

                    b.ToTable("Mechanic", (string)null);
                });

            modelBuilder.Entity("APBD_Retake.API.Models.Service", b =>
                {
                    b.Property<int>("Service_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Service_id"));

                    b.Property<decimal>("Base_fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Service_id");

                    b.ToTable("Service", (string)null);
                });

            modelBuilder.Entity("APBD_Retake.API.Models.Visit", b =>
                {
                    b.Property<int>("Visit_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Visit_id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("MechanicId")
                        .HasColumnType("int");

                    b.HasKey("Visit_id");

                    b.HasIndex("ClientId");

                    b.HasIndex("MechanicId");

                    b.ToTable("Visit", (string)null);
                });

            modelBuilder.Entity("APBD_Retake.API.Models.Visit_Service", b =>
                {
                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<decimal>("Service_fee")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VisitId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Visit_Service", (string)null);
                });

            modelBuilder.Entity("APBD_Retake.API.Models.Visit", b =>
                {
                    b.HasOne("APBD_Retake.API.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_Retake.API.Models.Mechanic", "Mechanic")
                        .WithMany()
                        .HasForeignKey("MechanicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Mechanic");
                });

            modelBuilder.Entity("APBD_Retake.API.Models.Visit_Service", b =>
                {
                    b.HasOne("APBD_Retake.API.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBD_Retake.API.Models.Visit", "Visit")
                        .WithMany()
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("Visit");
                });
#pragma warning restore 612, 618
        }
    }
}
