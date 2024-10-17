using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace limeify_be.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    ArtistId = table.Column<int>(type: "integer", nullable: false),
                    GenreId = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Bio = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Uid = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: false),
                    Artist = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ArtistId = table.Column<int>(type: "integer", nullable: false),
                    AlbumId = table.Column<int>(type: "integer", nullable: false),
                    GenreId = table.Column<int>(type: "integer", nullable: false),
                    Length = table.Column<int>(type: "integer", nullable: false),
                    PlaylistId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Songs_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Songs_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "ArtistId", "GenreId", "Image", "Name", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, "https://upload.wikimedia.org/wikipedia/en/9/9b/Tame_Impala_-_Currents.png", "Currents", 2015 },
                    { 2, 2, 1, "https://t2.genius.com/unsafe/383x0/https%3A%2F%2Fimages.genius.com%2F5f9a6674593806ac72677141c0e66330.1000x1000x1.png", "Father of the Bride", 2019 },
                    { 3, 3, 1, "https://upload.wikimedia.org/wikipedia/en/2/23/Phoebe_Bridgers_Punisher_%282020%29.png", "Punisher", 2020 },
                    { 4, 4, 2, "https://upload.wikimedia.org/wikipedia/en/e/e3/Luke_Combs_-_What_You_See_Is_What_You_Get.png", "What You See Is What You Get", 2019 },
                    { 5, 5, 2, "https://upload.wikimedia.org/wikipedia/en/thumb/d/dc/Carrie_Underwood_-_Cry_Pretty_%28Official_Album_Cover%29.png/220px-Carrie_Underwood_-_Cry_Pretty_%28Official_Album_Cover%29.png", "Cry Pretty", 2018 },
                    { 6, 6, 2, "https://upload.wikimedia.org/wikipedia/en/6/65/Kacey_Musgraves_-_Golden_Hour.png", "Golden Hour", 2018 },
                    { 7, 7, 3, "https://upload.wikimedia.org/wikipedia/en/c/c5/Southeasternjasonisbell.jpg", "Southeastern", 2013 },
                    { 8, 8, 3, "https://upload.wikimedia.org/wikipedia/en/1/18/The_Carpenter_%28The_Avett_Brothers%29_cover_art.jpg", "The Carpenter", 2012 },
                    { 9, 9, 3, "https://upload.wikimedia.org/wikipedia/en/e/ec/By_the_Way%2C_I_Forgive_You_-_Brandi_Carlile.png", "By the Way, I Forgive You", 2018 },
                    { 10, 10, 4, "https://upload.wikimedia.org/wikipedia/en/f/f6/Taylor_Swift_-_1989.png", "1989", 2014 },
                    { 11, 11, 4, "https://upload.wikimedia.org/wikipedia/en/a/a0/Ariana_Grande_-_Positions.png", "Positions", 2020 },
                    { 12, 12, 4, "https://upload.wikimedia.org/wikipedia/en/f/f5/Dua_Lipa_-_Future_Nostalgia_%28Official_Album_Cover%29.png", "Future Nostalgia", 2020 },
                    { 13, 13, 5, "https://upload.wikimedia.org/wikipedia/en/b/b2/Metallica_-_Master_of_Puppets_cover.jpg", "Master of Puppets", 1986 },
                    { 14, 14, 5, "https://upload.wikimedia.org/wikipedia/en/thumb/3/32/IronMaiden_NumberOfBeast.jpg/220px-IronMaiden_NumberOfBeast.jpg", "The Number of the Beast", 1982 },
                    { 15, 15, 5, "https://upload.wikimedia.org/wikipedia/en/1/1d/Slipknot_Iowa.jpg", "Iowa", 2001 },
                    { 16, 16, 6, "https://upload.wikimedia.org/wikipedia/en/f/f6/Kendrick_Lamar_-_To_Pimp_a_Butterfly.png", "To Pimp a Butterfly", 2015 },
                    { 17, 17, 6, "https://upload.wikimedia.org/wikipedia/en/9/90/Scorpion_by_Drake.jpg", "Scorpion", 2018 },
                    { 18, 18, 6, "https://upload.wikimedia.org/wikipedia/en/2/2a/2014ForestHillsDrive.jpg", "2014 Forest Hills Drive", 2014 },
                    { 19, 19, 7, "https://upload.wikimedia.org/wikipedia/en/2/2c/The_Blueprint.png", "The Blueprint", 2001 },
                    { 20, 20, 7, "https://i.pinimg.com/736x/91/06/66/910666f35cc2c190e585bdda709567fc.jpg", "Queen", 2018 },
                    { 21, 21, 7, "https://upload.wikimedia.org/wikipedia/en/9/97/Cardi_B_-_Invasion_of_Privacy.png", "Invasion of Privacy", 2018 },
                    { 22, 22, 8, "https://upload.wikimedia.org/wikipedia/en/5/53/Beyonce_-_Lemonade_%28Official_Album_Cover%29.png", "Lemonade", 2016 },
                    { 23, 23, 8, "https://upload.wikimedia.org/wikipedia/en/thumb/c/c1/The_Weeknd_-_After_Hours.png/220px-The_Weeknd_-_After_Hours.png", "After Hours", 2020 },
                    { 24, 24, 8, "https://upload.wikimedia.org/wikipedia/en/a/a0/Blonde_-_Frank_Ocean.jpeg", "Blonde", 2016 },
                    { 25, 25, 9, "https://upload.wikimedia.org/wikipedia/en/b/ba/Radioheadokcomputer.png", "OK Computer", 1997 },
                    { 26, 26, 9, "https://upload.wikimedia.org/wikipedia/en/1/17/The_Killers_-_Hot_Fuss.png", "Hot Fuss", 2004 },
                    { 27, 27, 9, "https://upload.wikimedia.org/wikipedia/en/8/81/Arcade_Fire_-_The_Suburbs.jpg", "The Suburbs", 2010 },
                    { 28, 28, 10, "https://m.media-amazon.com/images/I/81m8mrMsfAL._UF1000,1000_QL80_.jpg", "Ramones", 1976 },
                    { 29, 29, 10, "https://upload.wikimedia.org/wikipedia/en/4/4b/Green_Day_-_Dookie_cover.jpg", "Dookie", 1994 },
                    { 30, 30, 10, "https://upload.wikimedia.org/wikipedia/en/0/00/TheClashLondonCallingalbumcover.jpg", "London Calling", 1979 },
                    { 31, 31, 11, "https://upload.wikimedia.org/wikipedia/en/e/ea/Blackparadecover.jpg", "The Black Parade", 2006 },
                    { 32, 32, 11, "https://upload.wikimedia.org/wikipedia/en/thumb/7/7b/Brand_New_Deja_Entendu.jpg/220px-Brand_New_Deja_Entendu.jpg", "Deja Entendu", 2003 },
                    { 33, 33, 11, "https://upload.wikimedia.org/wikipedia/en/0/00/Fall_Out_Boy_-_From_Under_the_Cork_Tree_-_CD_album_cover.jpg", "From Under the Cork Tree", 2005 },
                    { 34, 34, 12, "https://upload.wikimedia.org/wikipedia/en/4/4b/My_Bloody_Valentine_-_Loveless.png", "Loveless", 1991 },
                    { 35, 35, 12, "https://upload.wikimedia.org/wikipedia/en/a/a6/Souvlaki_%28album%29_cover.jpg", "Souvlaki", 1993 },
                    { 36, 36, 12, "https://upload.wikimedia.org/wikipedia/en/9/9b/Nowhereridecover.jpg", "Nowhere", 1990 },
                    { 37, 37, 13, "https://upload.wikimedia.org/wikipedia/en/thumb/e/e6/American_football_band_lp_cover.png/220px-American_football_band_lp_cover.png", "American Football", 1999 },
                    { 38, 38, 13, "https://upload.wikimedia.org/wikipedia/en/thumb/d/d0/For_Long_Tomorrow.jpg/220px-For_Long_Tomorrow.jpg", "For Long Tomorrow", 2009 },
                    { 39, 39, 13, "https://upload.wikimedia.org/wikipedia/en/8/8f/Animals_%28This_Town_Needs_Guns_album%29.jpeg", "Animals", 2008 },
                    { 40, 40, 14, "https://t2.gstatic.com/licensed-image?q=tbn:ANd9GcT9kry1myZTi2dMJ7OtgJjmdT__lImpI-pJ9mdq42Cz8HhIet_ro_Obp6q4xbksBbpT", "The Dark Side of the Moon", 1973 },
                    { 41, 41, 14, "https://upload.wikimedia.org/wikipedia/en/0/09/Yes-close.jpg", "Close to the Edge", 1972 },
                    { 42, 42, 14, "https://upload.wikimedia.org/wikipedia/en/8/84/In_the_Court_of_the_Crimson_King_-_40th_Anniversary_Box_Set_-_Front_cover.jpeg", "In the Court of the Crimson King", 1969 },
                    { 43, 43, 15, "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Ninth_Symphony_original.png/1200px-Ninth_Symphony_original.png", "Symphony No. 9", 1824 },
                    { 44, 44, 15, "https://upload.wikimedia.org/wikipedia/commons/3/3e/Mozart_magic_flute.jpg", "The Magic Flute", 1791 },
                    { 45, 45, 15, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDbK128Dg3CQyAyUSp-wgXsA4gfSSTYxFf0g&s", "The Well-Tempered Clavier", 1722 }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Bio", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Tame Impala is the psychedelic music project led by Australian multi-instrumentalist Kevin Parker.", "https://www.rollingstone.com/wp-content/uploads/2019/05/tame-impala-lead-photo.jpg?w=1600&h=900&crop=1", "Tame Impala" },
                    { 2, "Vampire Weekend is an American indie rock band known for blending baroque pop, African influences, and indie rock.", "https://www.rollingstone.com/wp-content/uploads/2018/06/vampire-weekend-debut-album-abcc4ca0-a4df-4c7b-95ca-ad447c4142d2.jpg", "Vampire Weekend" },
                    { 3, "Phoebe Bridgers is an American indie singer-songwriter known for her introspective lyrics and haunting voice.", "https://ca-times.brightspotcdn.com/dims4/default/ac37e6d/2147483647/strip/false/crop/3492x2298+0+0/resize/1486x978!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F03%2F3d%2Fe3ef1ead45349f30c310a1554d3d%2Fhttps-delivery.gettyimages.com%2Fdownloads%2F1270300100", "Phoebe Bridgers" },
                    { 4, "Luke Combs is an American country singer-songwriter who has achieved rapid success with a blend of modern and traditional country sounds.", "https://resources.tidal.com/images/72cb8594/f5c6/41c2/be8d/b4ef5152baef/750x750.jpg", "Luke Combs" },
                    { 5, "Carrie Underwood is a country music icon known for her powerful voice and chart-topping hits.", "https://amp.nbc.com/sites/nbcblog/files/2023/10/carrie-underwood.jpg", "Carrie Underwood" },
                    { 6, "Kacey Musgraves is a Grammy-winning country artist whose music bridges traditional and modern influences.", "https://static.stereogum.com/uploads/2019/01/GettyImages-1080542124-1548878332-1000x667.jpg", "Kacey Musgraves" },
                    { 7, "Jason Isbell is an Americana artist known for his powerful songwriting and contributions to modern southern rock.", "https://i8.amplience.net/i/naras/jason-isbell_MI0004810104-MN0000562615", "Jason Isbell" },
                    { 8, "The Avett Brothers are a folk rock band whose music combines bluegrass, country, and punk influences.", "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-13745-20131210-avett-x1800-1386694348.jpg", "The Avett Brothers" },
                    { 9, "Brandi Carlile is an acclaimed Americana artist known for her emotive voice and genre-spanning songwriting.", "https://dgpuo8cwvztoe.cloudfront.net/uploads/_f_lg/brandi_carlile-Mary-Ellen-Matthews.jpg", "Brandi Carlile" },
                    { 10, "Taylor Swift is an American singer-songwriter whose career has spanned country, pop, and alternative genres.", "https://deadline.com/wp-content/uploads/2024/10/Taylor-Swift-2170709912.jpg?w=681&h=383&crop=1", "Taylor Swift" },
                    { 11, "Ariana Grande is a pop superstar known for her powerful vocals and chart-topping hits.", "https://www.billboard.com/wp-content/uploads/2022/08/Ariana-Grande-the-voice-2021-billboard-1548.jpg?w=1024", "Ariana Grande" },
                    { 12, "Dua Lipa is a British pop sensation known for her disco-inspired sound and dance-pop hits.", "https://media.gq.com/photos/5a5f79d835be9e1aebeceecf/4:3/w_4556,h_3417,c_limit/Dua_Lipa_01.jpg", "Dua Lipa" },
                    { 13, "Metallica is a legendary heavy metal band known for their aggressive sound and influence on the genre.", "https://northernvirginiamag.com/wp-content/uploads/2024/09/metallica1_ross_halfin_photographer-copy.webp", "Metallica" },
                    { 14, "Iron Maiden is a British heavy metal band known for their elaborate stage shows and complex compositions.", "https://www.ironmaiden.com/files/2024/08/WS_2023_Lineup.jpg", "Iron Maiden" },
                    { 15, "Slipknot is an American heavy metal band known for their intense live performances and masked personas.", "https://i.scdn.co/image/ab6761610000e5ebd0cdb283a7384a0edb665182", "Slipknot" },
                    { 16, "Kendrick Lamar is a Pulitzer Prize-winning rapper known for his socially conscious lyrics and innovative sound.", "https://variety.com/wp-content/uploads/2017/11/kendrick-lamar-variety-hitmakers.jpg?w=1000&h=562&crop=1", "Kendrick Lamar" },
                    { 17, "Drake is a Canadian rapper and singer whose music blends rap, R&B, and pop influences.", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQstSLn_yCOFPQ66fJ17gyaUpHsuE_l3dLNow&s", "Drake" },
                    { 18, "J. Cole is an American rapper and producer known for his introspective lyrics and storytelling ability.", "https://i1.sndcdn.com/avatars-CkLqCmTeMPSVzN50-GiKLzA-t1080x1080.jpg", "J. Cole" },
                    { 19, "Jay-Z is a hip hop mogul and one of the most influential rappers of all time.", "https://people.com/thmb/Im3tORdvaReCzwJDAZyvzhCTNb4=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(704x369:706x371)/jay-z-edf6090ede3c4547a47da0cf9c633778.jpg", "Jay-Z" },
                    { 20, "Nicki Minaj is a hip hop and pop artist known for her bold personality and genre-bending hits.", "https://media.npr.org/assets/img/2023/09/01/minaj_custom-b03a0992f23b6fe5d3d5add53c8920cd1b7e0c42.jpg", "Nicki Minaj" },
                    { 21, "Cardi B is a Grammy-winning rapper known for her energetic performances and charismatic personality.", "https://globalnews.ca/wp-content/uploads/2023/07/GettyImages-1512301113.jpg?quality=85&strip=all&w=1200", "Cardi B" },
                    { 22, "Beyoncé is a global superstar and one of the most influential R&B artists of her generation.", "https://media.glamour.com/photos/5cb7a1bf79e625ccc25b462c/master/pass/GettyImages-946416208.jpg", "Beyoncé" },
                    { 23, "The Weeknd is a Canadian R&B singer known for his moody sound and chart-topping hits.", "https://www.rollingstone.com/wp-content/uploads/2020/02/THE-WEEKND-by-Duncan-Loudon.jpg?w=1581&h=1054&crop=1", "The Weeknd" },
                    { 24, "Frank Ocean is an American singer-songwriter whose music combines R&B, soul, and alternative influences.", "https://www.hollywoodinsider.com/wp-content/uploads/2020/09/Hollywood-Insider-Frank-Ocean-Letter-From-Fan.jpg", "Frank Ocean" },
                    { 25, "Radiohead is a British alternative rock band known for their experimental sound and boundary-pushing music.", "https://images.bauerhosting.com/marketing/sites/16/2023/05/Radiohead-1995-hero.jpg?ar=16%3A9&fit=crop&crop=top&auto=format&w=undefined&q=80", "Radiohead" },
                    { 26, "The Killers are an American rock band whose music blends alternative rock, new wave, and synth-pop.", "https://www.rollingstone.com/wp-content/uploads/2024/08/Photo-3-202106_The-Killers4981_no91_no6.jpg?w=1581&h=1054&crop=1", "The Killers" },
                    { 27, "Arcade Fire is a Canadian indie rock band known for their ambitious albums and eclectic sound.", "https://i.guim.co.uk/img/media/da207ed976e1b316bab8a8ae547b6dbdc992911f/504_0_4674_2805/master/4674.jpg?width=1200&height=900&quality=85&auto=format&fit=crop&s=0f625bcdff3a9aede290d4cfa832dcfa", "Arcade Fire" },
                    { 28, "The Ramones were a pioneering American punk rock band known for their fast, stripped-down sound.", "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-226789-BPW2FR.jpg?w=1581&h=1054&crop=1", "The Ramones" },
                    { 29, "Green Day is an American punk rock band that brought punk back to the mainstream in the 1990s.", "https://media.npr.org/assets/img/2024/01/29/green_day_hires-13_alice-baxley-applemusic-ef3e58054af3256bb65e4790038cb245758a6898.jpg", "Green Day" },
                    { 30, "The Sex Pistols were a British punk rock band known for their rebellious attitude and provocative music.", "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-183232-85094733.jpg?w=1581&h=1054&crop=1", "Sex Pistols" },
                    { 31, "My Chemical Romance is an American rock band known for their emo and punk-inspired sound.", "https://m.media-amazon.com/images/M/MV5BYmQwMTM1MTgtNDBhMy00ODY4LWFjOWItYzU4MGZkNmNhYzNiXkEyXkFqcGc@._V1_.jpg", "My Chemical Romance" },
                    { 32, "Dashboard Confessional is an American emo band known for their heartfelt lyrics and acoustic sound.", "https://www.billboard.com/wp-content/uploads/media/Dashboard-Confessional-2020-cr-Dave-Bean-billboard-1548.jpg?w=1024", "Dashboard Confessional" },
                    { 33, "Fall Out Boy is an American rock band known for their blend of pop-punk, emo, and alternative rock.", "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-179980-461150986.jpg?w=1581&h=1054&crop=1", "Fall Out Boy" },
                    { 34, "My Bloody Valentine is an Irish-English band credited with pioneering the shoegaze genre with their swirling guitar effects.", "https://d94thh4m1x8qv.cloudfront.net/eyJidWNrZXQiOiJkaXktbWFnYXppbmUiLCJrZXkiOiJkL2RpeS9BcnRpc3RzL00vTXktQmxvb2R5LVZhbGVudGluZS9QcmVzcy1zaG90LTIuanBnIiwiZWRpdHMiOnsianBlZyI6eyJxdWFsaXR5IjoxMDAsInByb2dyZXNzaXZlIjp0cnVlLCJ0cmVsbGlzUXVhbnRpc2F0aW9uIjp0cnVlLCJvdmVyc2hvb3REZXJpbmdpbmciOnRydWUsIm9wdGltaXplU2NhbnMiOnRydWV9LCJyZXNpemUiOnsid2lkdGgiOjE1MDAsImhlaWdodCI6MTAwMCwiZml0IjoiY292ZXIifX19", "My Bloody Valentine" },
                    { 35, "Slowdive is a British shoegaze band known for their atmospheric sound and lush guitar textures.", "https://heights-photos.s3.amazonaws.com/wp-content/uploads/2023/09/08003435/unnamed-1145x628.jpg", "Slowdive" },
                    { 36, "Ride is an English shoegaze band whose blend of noise rock and ethereal vocals defined the genre's early years.", "https://media.pitchfork.com/photos/592c55e70c2bba1b7de04698/master/pass/57dd23b1.jpg", "Ride" },
                    { 37, "American Football is a band that blends math rock's technicality with the emotional depth of emo.", "https://media.npr.org/assets/img/2016/10/11/americanfootballshervinlainezpress_wide-2fd88fc6a0049eb368b81d7ca0fed85bc55d1c2e.jpg", "American Football" },
                    { 38, "Toe is a Japanese instrumental math rock band known for their intricate rhythms and emotive performances.", "https://f4.bcbits.com/img/0004501051_10.jpg", "Toe" },
                    { 39, "TTNG is a British math rock band known for their complex guitar work and shifting time signatures.", "https://lastfm.freetls.fastly.net/i/u/ar0/066981738de4463080c3a02cc1bba55e.jpg", "TTNG (This Town Needs Guns)" },
                    { 40, "Pink Floyd is an iconic British progressive rock band known for their concept albums and psychedelic sound.", "https://i.scdn.co/image/d011c95081cd9a329e506abd7ded47535d524a07", "Pink Floyd" },
                    { 41, "Yes is a British prog rock band known for their complex compositions and virtuosic musicianship.", "https://www.udiscovermusic.com/wp-content/uploads/2020/04/Yes-GettyImages-107731098-1.png", "Yes" },
                    { 42, "King Crimson is a British prog rock band whose music pushed the boundaries of rock with experimental elements.", "https://www.rollingstone.com/wp-content/uploads/2019/09/KingCrimson-1.jpg?w=1581&h=1054&crop=1", "King Crimson" },
                    { 43, "Ludwig van Beethoven was a German composer and pianist whose work marked the transition between the Classical and Romantic eras.", "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Joseph_Karl_Stieler%27s_Beethoven_mit_dem_Manuskript_der_Missa_solemnis.jpg/1200px-Joseph_Karl_Stieler%27s_Beethoven_mit_dem_Manuskript_der_Missa_solemnis.jpg", "Ludwig van Beethoven" },
                    { 44, "Mozart was a prolific and influential composer of the Classical era known for his symphonies, concertos, and operas.", "https://cdn.britannica.com/35/74835-050-F0B71060/canvas-oil-Wolfgang-Amadeus-Mozart-Barbara-Krafft-1819.jpg", "Wolfgang Amadeus Mozart" },
                    { 45, "Bach was a German composer and musician whose compositions are considered masterpieces of Baroque music.", "https://upload.wikimedia.org/wikipedia/commons/6/6a/Johann_Sebastian_Bach.jpg", "Johann Sebastian Bach" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Relaxing" },
                    { 2, "Dance" },
                    { 3, "Classics" },
                    { 4, "Indie" },
                    { 5, "Workout" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Indie" },
                    { 2, "Country" },
                    { 3, "Americana" },
                    { 4, "Pop" },
                    { 5, "Metal" },
                    { 6, "Rap" },
                    { 7, "Hip Hop" },
                    { 8, "R&B" },
                    { 9, "Alternative" },
                    { 10, "Punk" },
                    { 11, "Emo" },
                    { 12, "Shoegaze" },
                    { 13, "Math Rock" },
                    { 14, "Prog Rock" },
                    { 15, "Classical" }
                });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Uid" },
                values: new object[,]
                {
                    { 1, 1, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoJpfC3FIYyvcvdKVu0C7aCgqPG9N8EnnfLA&s", "Chill Vibes", "C0wunKp1sIQRM9YR48JnQPlNXt91" },
                    { 2, 2, "https://i1.sndcdn.com/artworks-myKVvYfZpg0PzyNa-ZUliJQ-t500x500.jpg", "Party Hits", "C0wunKp1sIQRM9YR48JnQPlNXt92" },
                    { 3, 3, "https://i1.sndcdn.com/artworks-000223861579-icm151-t500x500.jpg", "Throwback Classics", "C0wunKp1sIQRM9YR48JnQPlNXt93" },
                    { 4, 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRSASIn6nOKM53C64poBVRru1Cc-oONhdTUiw&s", "Indie Discoveries", "C0wunKp1sIQRM9YR48JnQPlNXt94" },
                    { 5, 5, "https://www.funslurp.com/images/baby-buff-1.jpg", "Workout Energy", "C0wunKp1sIQRM9YR48JnQPlNXt95" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Artist", "Email", "FirstName", "Image", "LastName", "Uid" },
                values: new object[,]
                {
                    { 1, false, "john.doe@example.com", "John", "https://example.com/images/john_doe.png", "Doe", "C0wunKp1sIQRM9YR48JnQPlNXt92" },
                    { 2, false, "jane.smith@example.com", "Jane", "https://example.com/images/jane_smith.png", "Smith", "D1zpqWr2bJUPO7YP39LkWPqMYu64" },
                    { 3, false, "alice.brown@example.com", "Alice", "https://example.com/images/alice_brown.png", "Brown", "E2fopHs3cIKQM8YS50MjYPmOZr85" },
                    { 4, false, "bob.johnson@example.com", "Bob", "https://example.com/images/bob_johnson.png", "Johnson", "F3grqUt4dLKRN9ZT61NkZQqPBr96" },
                    { 5, false, "charlie.williams@example.com", "Charlie", "https://example.com/images/charlie_williams.png", "Williams", "G4hsvVv5eMPRO0AU72OlASrQCr07" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "AlbumId", "ArtistId", "GenreId", "Length", "Name", "PlaylistId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 418, "Let It Happen", null },
                    { 2, 2, 2, 1, 257, "Harmony Hall", null },
                    { 3, 3, 3, 1, 265, "Kyoto", null },
                    { 4, 4, 4, 2, 203, "Beer Never Broke My Heart", null },
                    { 5, 5, 5, 2, 228, "Cry Pretty", null },
                    { 6, 6, 6, 2, 194, "Butterflies", null },
                    { 7, 7, 7, 3, 265, "Cover Me Up", null },
                    { 8, 8, 8, 3, 223, "I and Love and You", null },
                    { 9, 9, 9, 3, 268, "The Joke", null },
                    { 10, 10, 10, 4, 219, "Shake It Off", null },
                    { 11, 11, 11, 4, 182, "7 rings", null },
                    { 12, 12, 12, 4, 183, "Don't Start Now", null },
                    { 13, 13, 13, 5, 331, "Enter Sandman", null },
                    { 14, 14, 14, 5, 240, "The Trooper", null },
                    { 15, 15, 15, 5, 309, "Duality", null },
                    { 16, 16, 16, 6, 217, "Alright", null },
                    { 17, 17, 17, 6, 254, "In My Feelings", null },
                    { 18, 18, 18, 6, 261, "No Role Modelz", null },
                    { 19, 19, 19, 7, 220, "99 Problems", null },
                    { 20, 20, 20, 7, 237, "Super Bass", null },
                    { 21, 21, 21, 7, 259, "Bodak Yellow", null },
                    { 22, 22, 22, 8, 232, "Formation", null },
                    { 23, 23, 23, 8, 200, "Blinding Lights", null },
                    { 24, 24, 24, 8, 223, "Nikes", null },
                    { 25, 25, 25, 9, 258, "Karma Police", null },
                    { 26, 26, 26, 9, 221, "Mr. Brightside", null },
                    { 27, 27, 27, 9, 229, "The Suburbs", null },
                    { 28, 28, 28, 10, 143, "Blitzkrieg Bop", null },
                    { 29, 29, 29, 10, 195, "Basket Case", null },
                    { 30, 30, 30, 10, 210, "London Calling", null },
                    { 31, 31, 31, 11, 278, "Welcome to the Black Parade", null },
                    { 32, 32, 32, 11, 222, "The Boy Who Blocked His Own Shot", null },
                    { 33, 33, 33, 11, 210, "Sugar, We're Goin Down", null },
                    { 34, 34, 34, 12, 230, "Only Shallow", null },
                    { 35, 35, 35, 12, 216, "Alison", null },
                    { 36, 36, 36, 12, 263, "Vapour Trail", null },
                    { 37, 37, 37, 13, 213, "Never Meant", null },
                    { 38, 38, 38, 13, 220, "Goodbye", null },
                    { 39, 39, 39, 13, 192, "Catastrophe", null },
                    { 40, 40, 40, 14, 414, "Time", null },
                    { 41, 41, 41, 14, 408, "Roundabout", null },
                    { 42, 42, 42, 14, 420, "21st Century Schizoid Man", null },
                    { 43, 43, 43, 15, 4800, "Symphony No. 9 in D minor, Op. 125", null },
                    { 44, 44, 44, 15, 3000, "The Magic Flute, K. 620", null },
                    { 45, 45, 45, 15, 230, "Prelude and Fugue in C major, BWV 846", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumId",
                table: "Songs",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_ArtistId",
                table: "Songs",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_PlaylistId",
                table: "Songs",
                column: "PlaylistId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Playlists");
        }
    }
}
