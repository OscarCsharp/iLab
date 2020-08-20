﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200819234856_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("Description");

                    b.Property<string>("Status");

                    b.Property<string>("Title");

                    b.Property<string>("Year");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("API.Entities.BookingRecord", b =>
                {
                    b.Property<int>("BookingRecordId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<string>("CellNo");

                    b.Property<string>("CurrentOwner");

                    b.Property<string>("Email");

                    b.Property<DateTime>("RequestedDate");

                    b.Property<DateTime>("ReturnDate");

                    b.Property<string>("ReturnedBy");

                    b.Property<DateTime>("ReturnedOn");

                    b.Property<string>("Status");

                    b.HasKey("BookingRecordId");

                    b.HasIndex("BookId");

                    b.ToTable("BookingRecords");
                });

            modelBuilder.Entity("API.Entities.BookingRecord", b =>
                {
                    b.HasOne("API.Entities.Book", "Book")
                        .WithMany("BookingRecords")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
