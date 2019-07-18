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
    [Migration("20190716182200_NextMigration")]
    partial class NextMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PressPlay.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumTitle");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("RecordLabel");

                    b.HasKey("AlbumId");

                    b.ToTable("Album");

                    b.HasData(
                        new { AlbumId = 1, AlbumTitle = "KOD", ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstatic.vibe.com%2Ffiles%2F2018%2F04%2Fsixmau-j-cole-1524081746-650x366.png&imgrefurl=https%3A%2F%2Fwww.vibe.com%2F2018%2F04%2Fsixmau-j-cole-album-artwork&docid=DKGRHwn8XJ_J3M&tbnid=jcOT4-enJUjdzM%3A&vet=10ahUKEwi55cT94bnjAhV2Ap0JHT5BBHIQMwhXKAcwBw..i&w=650&h=366&bih=578&biw=1280&q=j%20cole%20kod&ved=0ahUKEwi55cT94bnjAhV2Ap0JHT5BBHIQMwhXKAcwBw&iact=mrc&uact=8", RecordLabel = "DreamVille" },
                        new { AlbumId = 2, AlbumTitle = "Thank you, Next", ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fuproxx.files.wordpress.com%2F2019%2F01%2Fariana-grande-thank-u-next-Republic.jpg%3Fquality%3D100%26w%3D650&imgrefurl=https%3A%2F%2Fuproxx.com%2Fmusic%2Fariana-grande-thank-u-next-album%2F&docid=AT8lOUifI4pOEM&tbnid=9xaq0DBN3lGy2M%3A&vet=10ahUKEwi8rpfT4rnjAhWQW80KHdbYC08QMwhjKBEwEQ..i&w=650&h=360&bih=578&biw=1280&q=ariana%20grande%20thank%20u%20next%20album%20iage&ved=0ahUKEwi8rpfT4rnjAhWQW80KHdbYC08QMwhjKBEwEQ&iact=mrc&uact=8", RecordLabel = "Matt" },
                        new { AlbumId = 3, AlbumTitle = "missundaztood", ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fen%2Ff%2Ffc%2FMisundazztodAlbum.jpg&imgrefurl=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FMissundaztood&docid=QSg0HS5C_zalQM&tbnid=sGzRB6THY0qn5M%3A&vet=10ahUKEwj0wLP04rnjAhWSZ80KHWn-BVcQMwhyKAEwAQ..i&w=300&h=300&bih=578&biw=1280&q=pink%20missundaztood%20album&ved=0ahUKEwj0wLP04rnjAhWSZ80KHWn-BVcQMwhyKAEwAQ&iact=mrc&uact=8", RecordLabel = "Jenny" },
                        new { AlbumId = 4, AlbumTitle = "Dystopia", ImageUrl = "https://www.google.com/imgres?imgurl=https%3A%2F%2Ftownsquare.media%2Fsite%2F295%2Ffiles%2F2015%2F10%2FDystopiaTopofStory-628x630.jpg%3Fw%3D980%26q%3D75&imgrefurl=https%3A%2F%2Fultimateclassicrock.com%2Fmegadeth-dystopia-album%2F&docid=LebK_2-ytDo9kM&tbnid=s4H_o6BbYDqNQM%3A&vet=10ahUKEwj-isyA47njAhVMZM0KHQH_D_wQMwh3KAUwBQ..i&w=980&h=983&bih=578&biw=1280&q=megadeth%20album%20covers&ved=0ahUKEwj-isyA47njAhVMZM0KHQH_D_wQMwh3KAUwBQ&iact=mrc&uact=8", RecordLabel = "Sergio" }
                    );
                });

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
                        new { ArtistId = 1, ArtistName = "J Cole", ImageUrl = "/Images/JCole.jpg" },
                        new { ArtistId = 2, ArtistName = "Ariana Grande", ImageUrl = "/Images/ArianaGrande.jpg" },
                        new { ArtistId = 3, ArtistName = "Pink", ImageUrl = "/Images/Pink.jpg" },
                        new { ArtistId = 4, ArtistName = "Megadeth", ImageUrl = "/Images/Megadeth.jpg" }
                    );
                });

            modelBuilder.Entity("PressPlay.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<int>("ArtistId");

                    b.Property<int>("Duration");

                    b.Property<string>("Link");

                    b.Property<string>("SongTitle");

                    b.HasKey("SongId");

                    b.ToTable("Song");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, ArtistId = 1, Duration = 132, Link = "https://www.youtube.com/watch?v=2hMy0rnHQv0", SongTitle = "Motiv8" },
                        new { SongId = 2, AlbumId = 2, ArtistId = 2, Duration = 182, Link = "https://www.youtube.com/watch?v=-_aGvdfLTKY", SongTitle = "Nasa" },
                        new { SongId = 3, AlbumId = 3, ArtistId = 3, Duration = 191, Link = "https://www.youtube.com/watch?v=mW1dbiD_zDk", SongTitle = "Get the Party Started" },
                        new { SongId = 4, AlbumId = 4, ArtistId = 4, Duration = 299, Link = "https://www.youtube.com/watch?v=bK95lWHl7js", SongTitle = "Dystopia" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
