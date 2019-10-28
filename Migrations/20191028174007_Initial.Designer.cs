﻿// <auto-generated />
using MessageBoard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard.Solution.Migrations
{
    [DbContext(typeof(MessageBoardContext))]
    [Migration("20191028174007_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MessageBoard.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("MessageBoard.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Body");

                    b.Property<int>("GroupId");

                    b.Property<string>("Title");

                    b.Property<string>("UserName");

                    b.HasKey("PostId");

                    b.HasIndex("GroupId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("MessageBoard.Models.Post", b =>
                {
                    b.HasOne("MessageBoard.Models.Group")
                        .WithMany("Posts")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
