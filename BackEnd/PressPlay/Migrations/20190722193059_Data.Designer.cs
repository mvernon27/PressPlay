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
    [Migration("20190722193059_Data")]
    partial class Data
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

                    b.Property<int>("ArtistId");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("RecordLabel");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Album");

                    b.HasData(
                        new { AlbumId = 1, AlbumTitle = "KOD", ArtistId = 1, ImageUrl = "https://media.pitchfork.com/photos/5ad8b39b5fadaa7e89cfd808/2:1/w_1000/KOD%20J.%20Cole.jpg", RecordLabel = "DreamVille" },
                        new { AlbumId = 2, AlbumTitle = "Sweetener", ArtistId = 2, ImageUrl = "https://www.udiscovermusic.com/wp-content/uploads/2018/06/Ariana-Grande-No-Tears-Left-To-Cry-packshot-cropped-web-optimised-1000.jpg", RecordLabel = "Republic Records" },
                        new { AlbumId = 3, AlbumTitle = "missundaztood", ArtistId = 3, ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/81GGshIlE4L._SL1200_.jpg", RecordLabel = "Arista Records" },
                        new { AlbumId = 4, AlbumTitle = "Rust In Peace", ArtistId = 4, ImageUrl = "https://i.ytimg.com/vi/SW6uObWJRH4/maxresdefault.jpg", RecordLabel = "Capitol Records" },
                        new { AlbumId = 5, AlbumTitle = "Play It Again", ArtistId = 5, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/4/44/Play_It_Again.jpg/220px-Play_It_Again.jpg", RecordLabel = "Capitol Nashville" },
                        new { AlbumId = 6, AlbumTitle = "Views", ArtistId = 6, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/af/Drake_-_Views_cover.jpg", RecordLabel = "Cash Money, Republic, Young Money" },
                        new { AlbumId = 7, AlbumTitle = "Lemonade", ArtistId = 7, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/53/Beyonce_-_Lemonade_%28Official_Album_Cover%29.png", RecordLabel = "Parkwood, Columbia" },
                        new { AlbumId = 8, AlbumTitle = "This One's for You", ArtistId = 8, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/5/5a/Combs_this_one.jpg", RecordLabel = "River House Artists, Columbia Nashville" },
                        new { AlbumId = 9, AlbumTitle = "Born Sinner", ArtistId = 1, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/21/J_Cole_Born_Sinner1.jpg", RecordLabel = "ByStorm, Columbia, Dreamville, Roc Nation" },
                        new { AlbumId = 10, AlbumTitle = "Dangerous Woman", ArtistId = 2, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/4b/Ariana_Grande_-_Dangerous_Woman_%28Official_Album_Cover%29.png", RecordLabel = "	Republic" },
                        new { AlbumId = 11, AlbumTitle = "Beautiful Trauma", ArtistId = 3, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8c/PINK_-_Beautiful_Trauma_%28Official_Album_Cover%29.png", RecordLabel = "RCA" },
                        new { AlbumId = 12, AlbumTitle = "Countdown to Extinction", ArtistId = 4, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Countdown_album_cover.jpg", RecordLabel = "Capitol" },
                        new { AlbumId = 13, AlbumTitle = "Kill the Lights", ArtistId = 5, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8f/Kill_the_Lights.jpg", RecordLabel = "Capitol Nashville" },
                        new { AlbumId = 14, AlbumTitle = "Take Care", ArtistId = 6, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/ae/Drake_-_Take_Care_cover.jpg", RecordLabel = "Young Money, Cash Money, Republic" },
                        new { AlbumId = 15, AlbumTitle = "4", ArtistId = 7, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/ca/Beyonc%C3%A9_-_4.png", RecordLabel = "Parkwood, Columbia" },
                        new { AlbumId = 16, AlbumTitle = "The Prequel", ArtistId = 8, ImageUrl = "https://upload.wikimedia.org/wikipedia/en/4/40/Luke_Combs_-_The_Prequel.png", RecordLabel = "River House Artists, Columbia Nashville" }
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
                        new { ArtistId = 1, ArtistName = "J Cole", ImageUrl = "https://i.ytimg.com/vi/UhD66RY3jt4/maxresdefault.jpg" },
                        new { ArtistId = 2, ArtistName = "Ariana Grande", ImageUrl = "https://www.androidred.com/wp-content/uploads/2019/01/Ariana-Grande-Special-background.jpg" },
                        new { ArtistId = 3, ArtistName = "Pink", ImageUrl = "https://ewscripps.brightspotcdn.com/dims4/default/ad6bfcf/2147483647/strip/true/crop/640x360+0+60/resize/1280x720!/quality/90/?url=https%3A%2F%2Fsharing.wxyz.com%2Fsharescnn%2Fphoto%2F2018%2F08%2F23%2FGettyImages-1000155580_1535076197337_95575003_ver1.0_640_480.jpg" },
                        new { ArtistId = 4, ArtistName = "Megadeth", ImageUrl = "https://images.wallpaperscraft.com/image/megadeth_hair_jackets_graphics_tie_6137_1280x720.jpg" },
                        new { ArtistId = 5, ArtistName = "Luke Bryan", ImageUrl = "https://www.soundslikenashville.com/wp-content/uploads/2015/02/Luke-Bryan-CountryMusicIsLove-e1423094611227.jpg" },
                        new { ArtistId = 6, ArtistName = "Drake", ImageUrl = "https://imagez.tmz.com/image/19/1by1/2018/05/03/1906e3b396275292a9534593c61c5b50_xl.jpg" },
                        new { ArtistId = 7, ArtistName = "Beyoncé", ImageUrl = "https://scontent-iad3-1.cdninstagram.com/vp/4915b3050db5904c61951f5495b41865/5DD178F6/t51.2885-15/e35/p1080x1080/65976770_471763230292454_4961231059076823417_n.jpg?_nc_ht=scontent-iad3-1.cdninstagram.com" },
                        new { ArtistId = 8, ArtistName = "Luke Combs", ImageUrl = "https://www.billboard.com/files/styles/article_main_image/public/media/Luke-Combs-bb14-2019-feat-billboard-bfhukopz-1548.jpg" }
                    );
                });

            modelBuilder.Entity("PressPlay.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AlbumId");

                    b.Property<int>("Duration");

                    b.Property<string>("Link");

                    b.Property<string>("SongTitle");

                    b.HasKey("SongId");

                    b.HasIndex("AlbumId");

                    b.ToTable("Song");

                    b.HasData(
                        new { SongId = 1, AlbumId = 1, Duration = 132, Link = "https://www.youtube.com/watch?v=2hMy0rnHQv0", SongTitle = "Motiv8" },
                        new { SongId = 2, AlbumId = 2, Duration = 182, Link = "https://www.youtube.com/watch?v=-_aGvdfLTKY", SongTitle = "Nasa" },
                        new { SongId = 3, AlbumId = 3, Duration = 191, Link = "https://www.youtube.com/watch?v=mW1dbiD_zDk", SongTitle = "Get the Party Started" },
                        new { SongId = 4, AlbumId = 4, Duration = 299, Link = "https://www.youtube.com/watch?v=Lcm9qqo_qB0", SongTitle = "Tornado of Souls" },
                        new { SongId = 5, AlbumId = 2, Duration = 206, Link = "https://www.youtube.com/watch?v=nNcDkT_AoHQ", SongTitle = "No Tears Left to Cry" },
                        new { SongId = 6, AlbumId = 2, Duration = 197, Link = "https://www.youtube.com/watch?v=kHLHSlExFis", SongTitle = "God Is a Woman" },
                        new { SongId = 7, AlbumId = 2, Duration = 198, Link = "https://www.youtube.com/watch?v=kN0iD0pI3o0", SongTitle = "Breathin" },
                        new { SongId = 8, AlbumId = 1, Duration = 216, Link = "https://www.youtube.com/watch?v=ew7qhDBQcU4", SongTitle = "ATM" },
                        new { SongId = 9, AlbumId = 1, Duration = 218, Link = "https://www.youtube.com/watch?v=tIRi44nVNCA", SongTitle = "Photograph" },
                        new { SongId = 10, AlbumId = 3, Duration = 210, Link = "https://www.youtube.com/watch?v=K_t9AA3Z4PE", SongTitle = "Don't Let Me Get Me" },
                        new { SongId = 11, AlbumId = 3, Duration = 237, Link = "https://www.youtube.com/watch?v=JDKGWaCglRM", SongTitle = "Just like a Pill" },
                        new { SongId = 12, AlbumId = 3, Duration = 298, Link = "https://www.youtube.com/watch?v=eZbj_caIAUE", SongTitle = "Family Portrait" },
                        new { SongId = 13, AlbumId = 4, Duration = 392, Link = "https://www.youtube.com/watch?v=9d4ui9q7eDM", SongTitle = "Holy Wars... The Punishment Due" },
                        new { SongId = 14, AlbumId = 4, Duration = 314, Link = "https://www.youtube.com/watch?v=B-oU2xlViRQ", SongTitle = "Hangar 18" },
                        new { SongId = 15, AlbumId = 5, Duration = 227, Link = "https://www.youtube.com/watch?v=ALV-QtDFpSw", SongTitle = "Play It Again" },
                        new { SongId = 16, AlbumId = 6, Duration = 267, Link = "https://www.youtube.com/watch?v=uxpDa-c-4Mc", SongTitle = "Hotline Bling" },
                        new { SongId = 17, AlbumId = 6, Duration = 174, Link = "https://www.youtube.com/watch?v=iAbnEUA0wpA", SongTitle = "One Dance" },
                        new { SongId = 18, AlbumId = 6, Duration = 209, Link = "https://www.youtube.com/watch?v=OJu4kkAbxHQ", SongTitle = "Pop Style" },
                        new { SongId = 19, AlbumId = 6, Duration = 245, Link = "https://www.youtube.com/watch?v=PnL3sg-tq7s", SongTitle = "Controlla" },
                        new { SongId = 20, AlbumId = 7, Duration = 216, Link = "https://www.youtube.com/watch?v=WDZJPJV__bQ", SongTitle = "Formation" },
                        new { SongId = 21, AlbumId = 7, Duration = 232, Link = "https://www.youtube.com/watch?v=QxsmWxxouIM", SongTitle = "Sorry" },
                        new { SongId = 22, AlbumId = 7, Duration = 221, Link = "https://www.youtube.com/watch?v=PeonBmeFR8o", SongTitle = "Hold Up" },
                        new { SongId = 23, AlbumId = 8, Duration = 223, Link = "https://www.youtube.com/watch?v=BixwVsiDdZM", SongTitle = "Hurricane" },
                        new { SongId = 24, AlbumId = 8, Duration = 242, Link = "https://www.youtube.com/watch?v=uXyxFMbqKYA", SongTitle = "When It Rains It Pours" },
                        new { SongId = 25, AlbumId = 8, Duration = 242, Link = "https://www.youtube.com/watch?v=Ct9BFr9XBaI", SongTitle = "One Number Away" },
                        new { SongId = 26, AlbumId = 8, Duration = 183, Link = "https://www.youtube.com/watch?v=a2a9fgPI_PI", SongTitle = "She Got the Best of Me" },
                        new { SongId = 27, AlbumId = 9, Duration = 240, Link = "https://www.youtube.com/watch?v=VMeirNg87AY", SongTitle = "Power Trip" },
                        new { SongId = 28, AlbumId = 9, Duration = 279, Link = "https://www.youtube.com/watch?v=eCxaXqwRhvw", SongTitle = "Crooked Smile" },
                        new { SongId = 29, AlbumId = 9, Duration = 269, Link = "https://www.youtube.com/watch?v=9-kWlUbkHS4", SongTitle = "Forbidden Fruit" },
                        new { SongId = 30, AlbumId = 9, Duration = 297, Link = "https://www.youtube.com/watch?v=jYdaQJzcAcw", SongTitle = "She Knows" },
                        new { SongId = 31, AlbumId = 10, Duration = 235, Link = "https://www.youtube.com/watch?v=9WbCfHutDSE", SongTitle = "Dangerous Woman" },
                        new { SongId = 32, AlbumId = 10, Duration = 244, Link = "https://www.youtube.com/watch?v=1ekZEVeXwek", SongTitle = "Into You" },
                        new { SongId = 33, AlbumId = 10, Duration = 226, Link = "https://www.youtube.com/watch?v=SXiSVQZLje8", SongTitle = "Side to Side" },
                        new { SongId = 34, AlbumId = 10, Duration = 194, Link = "https://www.youtube.com/watch?v=LELFIuhSPCI", SongTitle = "Everyday" },
                        new { SongId = 35, AlbumId = 11, Duration = 271, Link = "https://www.youtube.com/watch?v=ClU3fctbGls", SongTitle = "What About Us" },
                        new { SongId = 36, AlbumId = 11, Duration = 250, Link = "https://www.youtube.com/watch?v=EBt_88nxG4c", SongTitle = "Beautiful Trauma" },
                        new { SongId = 37, AlbumId = 11, Duration = 243, Link = "https://www.youtube.com/watch?v=xuAH21DkJow", SongTitle = "Whatever You Want" },
                        new { SongId = 38, AlbumId = 11, Duration = 210, Link = "https://www.youtube.com/watch?v=gL20Eaeswfk", SongTitle = "Secrets" },
                        new { SongId = 39, AlbumId = 12, Duration = 194, Link = "https://www.youtube.com/watch?v=i1PceyvqBlg", SongTitle = "Skin o' My Teeth" },
                        new { SongId = 40, AlbumId = 12, Duration = 247, Link = "https://www.youtube.com/watch?v=wEPKIulCEhQ", SongTitle = "Symphony of Destruction" },
                        new { SongId = 41, AlbumId = 12, Duration = 0, Link = "https://www.youtube.com/watch?v=GIAu9xQp-zo", SongTitle = "Foreclosure of a Dream" },
                        new { SongId = 42, AlbumId = 12, Duration = 269, Link = "https://www.youtube.com/watch?v=aOnKCcjP8Qs", SongTitle = "Sweating Bullets" },
                        new { SongId = 43, AlbumId = 13, Duration = 191, Link = "https://www.youtube.com/results?search_query=kick+the+dust-up", SongTitle = "Kick the Dust Up" },
                        new { SongId = 44, AlbumId = 13, Duration = 241, Link = "https://www.youtube.com/watch?v=kY2pJsOZvc4", SongTitle = "Strip It Down" },
                        new { SongId = 45, AlbumId = 13, Duration = 191, Link = "https://www.youtube.com/watch?v=f2Exzqu2ocs", SongTitle = "Home Alone Tonight" },
                        new { SongId = 46, AlbumId = 13, Duration = 278, Link = "https://www.youtube.com/results?search_query=huntin+fishin+and+lovin+everyday+lyrics", SongTitle = "Huntin', Fishin' and Lovin' Every Day" },
                        new { SongId = 47, AlbumId = 14, Duration = 182, Link = "https://www.youtube.com/watch?v=BYDKK95cpfM", SongTitle = "The Motto" },
                        new { SongId = 48, AlbumId = 14, Duration = 348, Link = "https://www.youtube.com/watch?v=JDb3ZZD4bA0", SongTitle = "Marvins Room" },
                        new { SongId = 49, AlbumId = 14, Duration = 236, Link = "https://www.youtube.com/watch?v=cimoNqiulUE", SongTitle = "Headlines" },
                        new { SongId = 50, AlbumId = 14, Duration = 220, Link = "https://www.youtube.com/watch?v=AP6ps5CxgVk", SongTitle = "Make Me Proud" },
                        new { SongId = 51, AlbumId = 15, Duration = 235, Link = "https://www.youtube.com/watch?v=VBmMU_iwe6U", SongTitle = "Run the World (Girls)" },
                        new { SongId = 52, AlbumId = 15, Duration = 253, Link = "https://www.youtube.com/watch?v=FHp2KgyQUFk", SongTitle = "Best Thing I Never Had" },
                        new { SongId = 53, AlbumId = 15, Duration = 245, Link = "https://www.youtube.com/watch?v=XWCwc1_sYMY", SongTitle = "Party" },
                        new { SongId = 54, AlbumId = 15, Duration = 267, Link = "https://www.youtube.com/watch?v=Ob7vObnFUJc", SongTitle = "Love on Top" },
                        new { SongId = 55, AlbumId = 16, Duration = 186, Link = "https://www.youtube.com/watch?v=7Lb9dq-JZFI", SongTitle = "Beer Never Broke My Heart" },
                        new { SongId = 56, AlbumId = 16, Duration = 204, Link = "https://www.youtube.com/watch?v=zeZVQOfkITU", SongTitle = "Refrigerator Door" },
                        new { SongId = 57, AlbumId = 16, Duration = 225, Link = "https://www.youtube.com/watch?v=8bjo95QKD3c", SongTitle = "Even Though I'm Leaving" },
                        new { SongId = 58, AlbumId = 16, Duration = 195, Link = "https://www.youtube.com/watch?v=x3TBvI2AZKA", SongTitle = "Lovin' on You" }
                    );
                });

            modelBuilder.Entity("PressPlay.Models.Album", b =>
                {
                    b.HasOne("PressPlay.Models.Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PressPlay.Models.Song", b =>
                {
                    b.HasOne("PressPlay.Models.Album")
                        .WithMany("Song")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
