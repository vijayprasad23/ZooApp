﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZooApp.data;

#nullable disable

namespace ZooApp.Migrations
{
    [DbContext(typeof(ZooAppContext))]
    partial class ZooAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ZooApp.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalId"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Diet")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EnclosureId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("Species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AnimalId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EnclosureId");

                    b.ToTable("Animal", (string)null);
                });

            modelBuilder.Entity("ZooApp.Models.AnimalEmployee", b =>
                {
                    b.Property<int>("AnimalEmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalEmployeeId"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("AnimalEmployeeId");

                    b.HasIndex("AnimalId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("AnimalEmployee", (string)null);
                });

            modelBuilder.Entity("ZooApp.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("EnclosureId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("EnclosureId");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("ZooApp.Models.Enclosure", b =>
                {
                    b.Property<int>("EnclosureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnclosureId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Habitat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnclosureId");

                    b.ToTable("Enclosure", (string)null);
                });

            modelBuilder.Entity("ZooApp.Models.Event", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TicketPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EventId");

                    b.ToTable("Event", (string)null);
                });

            modelBuilder.Entity("ZooApp.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<DateTime>("DateOfPurchase")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("VisitorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VisitorId1")
                        .HasColumnType("int");

                    b.HasKey("TicketId");

                    b.HasIndex("EventId");

                    b.HasIndex("VisitorId1");

                    b.ToTable("Ticket", (string)null);
                });

            modelBuilder.Entity("ZooApp.Models.Visitor", b =>
                {
                    b.Property<int>("VisitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VisitorId");

                    b.ToTable("Visitor", (string)null);
                });

            modelBuilder.Entity("ZooApp.Models.VisitorEventAttendance", b =>
                {
                    b.Property<int>("VisitorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorId"));

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("VisitorId1")
                        .HasColumnType("int");

                    b.HasKey("VisitorId");

                    b.HasIndex("EventId");

                    b.HasIndex("VisitorId1");

                    b.ToTable("VisitorAttendance", (string)null);
                });

            modelBuilder.Entity("ZooApp.Models.VisitorLog", b =>
                {
                    b.Property<int>("VisitorLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitorLogId"));

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateVisited")
                        .HasColumnType("datetime2");

                    b.Property<int>("VisitorId")
                        .HasColumnType("int");

                    b.HasKey("VisitorLogId");

                    b.HasIndex("VisitorId");

                    b.ToTable("VisitorLog", (string)null);
                });

            modelBuilder.Entity("ZooApp.Models.Animal", b =>
                {
                    b.HasOne("ZooApp.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooApp.Models.Enclosure", "Enclosure")
                        .WithMany("Animals")
                        .HasForeignKey("EnclosureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Enclosure");
                });

            modelBuilder.Entity("ZooApp.Models.AnimalEmployee", b =>
                {
                    b.HasOne("ZooApp.Models.Animal", "Animal")
                        .WithMany("AnimalZooEmployees")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooApp.Models.Employee", "Employee")
                        .WithMany("AnimalEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ZooApp.Models.Employee", b =>
                {
                    b.HasOne("ZooApp.Models.Enclosure", "Enclosure")
                        .WithMany("Employees")
                        .HasForeignKey("EnclosureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enclosure");
                });

            modelBuilder.Entity("ZooApp.Models.Ticket", b =>
                {
                    b.HasOne("ZooApp.Models.Event", "Event")
                        .WithMany("Tickets")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooApp.Models.Visitor", "Visitor")
                        .WithMany("Tickets")
                        .HasForeignKey("VisitorId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("ZooApp.Models.VisitorEventAttendance", b =>
                {
                    b.HasOne("ZooApp.Models.Event", "Event")
                        .WithMany("EventAttendances")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZooApp.Models.Visitor", "Visitor")
                        .WithMany("EventAttendances")
                        .HasForeignKey("VisitorId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("ZooApp.Models.VisitorLog", b =>
                {
                    b.HasOne("ZooApp.Models.Visitor", "Visitor")
                        .WithMany("VisitorLogs")
                        .HasForeignKey("VisitorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visitor");
                });

            modelBuilder.Entity("ZooApp.Models.Animal", b =>
                {
                    b.Navigation("AnimalZooEmployees");
                });

            modelBuilder.Entity("ZooApp.Models.Employee", b =>
                {
                    b.Navigation("AnimalEmployees");
                });

            modelBuilder.Entity("ZooApp.Models.Enclosure", b =>
                {
                    b.Navigation("Animals");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ZooApp.Models.Event", b =>
                {
                    b.Navigation("EventAttendances");

                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("ZooApp.Models.Visitor", b =>
                {
                    b.Navigation("EventAttendances");

                    b.Navigation("Tickets");

                    b.Navigation("VisitorLogs");
                });
#pragma warning restore 612, 618
        }
    }
}
