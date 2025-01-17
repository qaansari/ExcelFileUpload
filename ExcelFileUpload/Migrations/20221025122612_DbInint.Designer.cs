﻿// <auto-generated />
using System;
using ExcelFileUpload.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExcelFileUpload.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221025122612_DbInint")]
    partial class DbInint
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExcelFileUpload.Models.User_Model.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            RoleID = 1,
                            Title = "Super Admin"
                        });
                });

            modelBuilder.Entity("ExcelFileUpload.Models.User_Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<int?>("CreatedByUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int?>("UpdatedByUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("UserID");

                    b.HasIndex("CreatedByUserID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            CreatedDateTime = new DateTime(2022, 10, 25, 17, 26, 11, 867, DateTimeKind.Utc).AddTicks(5508),
                            Email = "super_admin@share.com",
                            FirstName = "Super",
                            IsActive = true,
                            LastName = "Admin",
                            Password = "s8scmb168Cftrf3LG8cFMjQRHk8LXGSAC9iYfOIBymK3f1Jx/wY6Tpt7jccy2MWd17vta8mAcP74Eg+BFzOQew==",
                            RoleID = 1,
                            UpdatedDateTime = new DateTime(2022, 10, 25, 17, 26, 11, 867, DateTimeKind.Utc).AddTicks(5520)
                        });
                });

            modelBuilder.Entity("ExcelFileUpload.Models.User_Model.User", b =>
                {
                    b.HasOne("ExcelFileUpload.Models.User_Model.User", "CreatedByUser")
                        .WithMany()
                        .HasForeignKey("CreatedByUserID");

                    b.HasOne("ExcelFileUpload.Models.User_Model.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedByUser");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ExcelFileUpload.Models.User_Model.Role", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
