﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

#nullable disable

namespace HCA.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("HCA.Data.Entities.HCA_EmployeeDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HCA_EmployeeDetails");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Ponnusamy.r@altrockstech.com",
                            Name = "Altrocks1"
                        },
                        new
                        {
                            Id = 2,
                            Email = "bharath.p@altrockstech.com",
                            Name = "Altrocks2"
                        });
                });

            modelBuilder.Entity("HCA.Data.Entities.HCA_Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Createdby")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Modifiedby")
                        .HasColumnType("TEXT");

                    b.Property<string>("StatusDescription")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("HCA_Status");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 4, 24, 16, 33, 33, 570, DateTimeKind.Local).AddTicks(4103),
                            Createdby = "System",
                            IsActive = true,
                            StatusDescription = "Pending"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 4, 24, 16, 33, 33, 570, DateTimeKind.Local).AddTicks(4214),
                            Createdby = "System",
                            IsActive = true,
                            StatusDescription = "Completed"
                        });
                });

            modelBuilder.Entity("HCA.Data.Entities.TaskActivityMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ActivityDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ActivityDescription")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<int>("DoneBy")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("TaskId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DoneBy");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskActivityMapping");
                });

            modelBuilder.Entity("HCA.Data.Entities.TaskDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Createdby")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Due_date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Emailtriggered")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Modifiedby")
                        .HasColumnType("TEXT");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TaskName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("StatusId");

                    b.ToTable("TaskDetails");
                });

            modelBuilder.Entity("HCA.Data.Entities.TaskTagMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Createdby")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Modifiedby")
                        .HasColumnType("TEXT");

                    b.Property<string>("TagsName")
                        .HasColumnType("TEXT");

                    b.Property<int>("TaskId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("TaskTagMapping");
                });

            modelBuilder.Entity("HCA.Data.Entities.TaskActivityMapping", b =>
                {
                    b.HasOne("HCA.Data.Entities.HCA_EmployeeDetails", "DoneByEmployee")
                        .WithMany()
                        .HasForeignKey("DoneBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HCA.Data.Entities.TaskDetails", "TaskDetails")
                        .WithMany("objTaskActivity")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoneByEmployee");

                    b.Navigation("TaskDetails");
                });

            modelBuilder.Entity("HCA.Data.Entities.TaskDetails", b =>
                {
                    b.HasOne("HCA.Data.Entities.HCA_EmployeeDetails", "EmployeeDetails")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HCA.Data.Entities.HCA_Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeDetails");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("HCA.Data.Entities.TaskTagMapping", b =>
                {
                    b.HasOne("HCA.Data.Entities.TaskDetails", "TaskDetails")
                        .WithMany("objTaskTag")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaskDetails");
                });

            modelBuilder.Entity("HCA.Data.Entities.TaskDetails", b =>
                {
                    b.Navigation("objTaskActivity");

                    b.Navigation("objTaskTag");
                });
#pragma warning restore 612, 618
        }
    }
}
