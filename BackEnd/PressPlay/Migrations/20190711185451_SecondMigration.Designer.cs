﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PressPlay;

namespace PressPlay.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20190711185451_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PressPlay.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArtistName");

                    b.Property<string>("ImageUrl");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists");

                    b.HasData(
                        new { ArtistId = 1, ArtistName = "J Cole", ImageUrl = "/images/JCole.jpg/" },
                        new { ArtistId = 2, ArtistName = "Ariana Grande", ImageUrl = "/images/ArianaGrande.jpg/" },
                        new { ArtistId = 3, ArtistName = "Pink", ImageUrl = "/images/Pink.jpg/" },
                        new { ArtistId = 4, ArtistName = "Megadeth", ImageUrl = "/images/Megadeth.jpg" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
