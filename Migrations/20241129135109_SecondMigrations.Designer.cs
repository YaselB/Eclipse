﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using eclipse.Aplication;

#nullable disable

namespace Eclipse.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20241129135109_SecondMigrations")]
    partial class SecondMigrations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Rol", b =>
                {
                    b.Property<int>("IDRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDRol"));

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.Property<string>("UserRol")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IDRol");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Rols");
                });

            modelBuilder.Entity("eclipse.Aplication.Comentary", b =>
                {
                    b.Property<int>("IDComentary")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDComentary"));

                    b.Property<string>("Comentarytext")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Stars")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("IDComentary");

                    b.HasIndex("UserID");

                    b.ToTable("Comentarys");
                });

            modelBuilder.Entity("eclipse.Aplication.Navbar", b =>
                {
                    b.Property<int>("IDNavbar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDNavbar"));

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IDNavbar");

                    b.ToTable("Navbars");
                });

            modelBuilder.Entity("eclipse.Aplication.Price", b =>
                {
                    b.Property<int>("IDPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDPrice"));

                    b.Property<string>("Money")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TicketID")
                        .HasColumnType("integer");

                    b.Property<float>("value")
                        .HasColumnType("real");

                    b.HasKey("IDPrice");

                    b.HasIndex("TicketID");

                    b.ToTable("Price");
                });

            modelBuilder.Entity("eclipse.Aplication.Ticket", b =>
                {
                    b.Property<int>("IDTicket")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IDTicket"));

                    b.Property<string>("destination")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nameAirline")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("origin")
                        .IsRequired()
                        .HasColumnType("text");

                    b.PrimitiveCollection<string[]>("selectedDates")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("IDTicket");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("eclipse.Aplication.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("token")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Rol", b =>
                {
                    b.HasOne("eclipse.Aplication.User", "Username")
                        .WithOne("Rol")
                        .HasForeignKey("Rol", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Username");
                });

            modelBuilder.Entity("eclipse.Aplication.Comentary", b =>
                {
                    b.HasOne("eclipse.Aplication.User", "User")
                        .WithMany("Comentarys")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("eclipse.Aplication.Price", b =>
                {
                    b.HasOne("eclipse.Aplication.Ticket", "Ticket")
                        .WithMany("Prices")
                        .HasForeignKey("TicketID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("eclipse.Aplication.Ticket", b =>
                {
                    b.Navigation("Prices");
                });

            modelBuilder.Entity("eclipse.Aplication.User", b =>
                {
                    b.Navigation("Comentarys");

                    b.Navigation("Rol");
                });
#pragma warning restore 612, 618
        }
    }
}
