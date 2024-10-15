using Limeify.Models;

namespace Limeify.Data
{
    public class ArtistData
    {
        public static List<Artist> Artists = new()
        {
            // Indie
            new Artist
            {
                Id = 1,
                Name = "Tame Impala",
                Bio = "Tame Impala is the psychedelic music project led by Australian multi-instrumentalist Kevin Parker.",
                Image = "https://www.rollingstone.com/wp-content/uploads/2019/05/tame-impala-lead-photo.jpg?w=1600&h=900&crop=1"
            },
            new Artist
            {
                Id = 2,
                Name = "Vampire Weekend",
                Bio = "Vampire Weekend is an American indie rock band known for blending baroque pop, African influences, and indie rock.",
                Image = "https://www.rollingstone.com/wp-content/uploads/2018/06/vampire-weekend-debut-album-abcc4ca0-a4df-4c7b-95ca-ad447c4142d2.jpg"
            },
            new Artist
            {
                Id = 3,
                Name = "Phoebe Bridgers",
                Bio = "Phoebe Bridgers is an American indie singer-songwriter known for her introspective lyrics and haunting voice.",
                Image = "https://ca-times.brightspotcdn.com/dims4/default/ac37e6d/2147483647/strip/false/crop/3492x2298+0+0/resize/1486x978!/quality/75/?url=https%3A%2F%2Fcalifornia-times-brightspot.s3.amazonaws.com%2F03%2F3d%2Fe3ef1ead45349f30c310a1554d3d%2Fhttps-delivery.gettyimages.com%2Fdownloads%2F1270300100"
            },
    
            // Country
            new Artist
            {
                Id = 4,
                Name = "Luke Combs",
                Bio = "Luke Combs is an American country singer-songwriter who has achieved rapid success with a blend of modern and traditional country sounds.",
                Image = "https://resources.tidal.com/images/72cb8594/f5c6/41c2/be8d/b4ef5152baef/750x750.jpg"
            },
            new Artist
            {
                Id = 5,
                Name = "Carrie Underwood",
                Bio = "Carrie Underwood is a country music icon known for her powerful voice and chart-topping hits.",
                Image = "https://amp.nbc.com/sites/nbcblog/files/2023/10/carrie-underwood.jpg"
            },
            new Artist
            {
                Id = 6,
                Name = "Kacey Musgraves",
                Bio = "Kacey Musgraves is a Grammy-winning country artist whose music bridges traditional and modern influences.",
                Image = "https://static.stereogum.com/uploads/2019/01/GettyImages-1080542124-1548878332-1000x667.jpg"
            },
    
            // Americana
            new Artist
            {
                Id = 7,
                Name = "Jason Isbell",
                Bio = "Jason Isbell is an Americana artist known for his powerful songwriting and contributions to modern southern rock.",
                Image = "https://i8.amplience.net/i/naras/jason-isbell_MI0004810104-MN0000562615"
            },
            new Artist
            {
                Id = 8,
                Name = "The Avett Brothers",
                Bio = "The Avett Brothers are a folk rock band whose music combines bluegrass, country, and punk influences.",
                Image = "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-13745-20131210-avett-x1800-1386694348.jpg"
            },
            new Artist
            {
                Id = 9,
                Name = "Brandi Carlile",
                Bio = "Brandi Carlile is an acclaimed Americana artist known for her emotive voice and genre-spanning songwriting.",
                Image = "https://dgpuo8cwvztoe.cloudfront.net/uploads/_f_lg/brandi_carlile-Mary-Ellen-Matthews.jpg"
            },
    
            // Pop
            new Artist
            {
                Id = 10,
                Name = "Taylor Swift",
                Bio = "Taylor Swift is an American singer-songwriter whose career has spanned country, pop, and alternative genres.",
                Image = "https://deadline.com/wp-content/uploads/2024/10/Taylor-Swift-2170709912.jpg?w=681&h=383&crop=1"
            },
            new Artist
            {
                Id = 11,
                Name = "Ariana Grande",
                Bio = "Ariana Grande is a pop superstar known for her powerful vocals and chart-topping hits.",
                Image = "https://www.billboard.com/wp-content/uploads/2022/08/Ariana-Grande-the-voice-2021-billboard-1548.jpg?w=1024"
            },
            new Artist
            {
                Id = 12,
                Name = "Dua Lipa",
                Bio = "Dua Lipa is a British pop sensation known for her disco-inspired sound and dance-pop hits.",
                Image = "https://media.gq.com/photos/5a5f79d835be9e1aebeceecf/4:3/w_4556,h_3417,c_limit/Dua_Lipa_01.jpg"
            },
    
            // Metal
            new Artist
            {
                Id = 13,
                Name = "Metallica",
                Bio = "Metallica is a legendary heavy metal band known for their aggressive sound and influence on the genre.",
                Image = "https://northernvirginiamag.com/wp-content/uploads/2024/09/metallica1_ross_halfin_photographer-copy.webp"
            },
            new Artist
            {
                Id = 14,
                Name = "Iron Maiden",
                Bio = "Iron Maiden is a British heavy metal band known for their elaborate stage shows and complex compositions.",
                Image = "https://www.ironmaiden.com/files/2024/08/WS_2023_Lineup.jpg"
            },
            new Artist
            {
                Id = 15,
                Name = "Slipknot",
                Bio = "Slipknot is an American heavy metal band known for their intense live performances and masked personas.",
                Image = "https://i.scdn.co/image/ab6761610000e5ebd0cdb283a7384a0edb665182"
            },
    
            // Rap
            new Artist
            {
                Id = 16,
                Name = "Kendrick Lamar",
                Bio = "Kendrick Lamar is a Pulitzer Prize-winning rapper known for his socially conscious lyrics and innovative sound.",
                Image = "https://variety.com/wp-content/uploads/2017/11/kendrick-lamar-variety-hitmakers.jpg?w=1000&h=562&crop=1"
            },
            new Artist
            {
                Id = 17,
                Name = "Drake",
                Bio = "Drake is a Canadian rapper and singer whose music blends rap, R&B, and pop influences.",
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQstSLn_yCOFPQ66fJ17gyaUpHsuE_l3dLNow&s"
            },
            new Artist
            {
                Id = 18,
                Name = "J. Cole",
                Bio = "J. Cole is an American rapper and producer known for his introspective lyrics and storytelling ability.",
                Image = "https://i1.sndcdn.com/avatars-CkLqCmTeMPSVzN50-GiKLzA-t1080x1080.jpg"
            },
    
            // Hip Hop
            new Artist
            {
                Id = 19,
                Name = "Jay-Z",
                Bio = "Jay-Z is a hip hop mogul and one of the most influential rappers of all time.",
                Image = "https://people.com/thmb/Im3tORdvaReCzwJDAZyvzhCTNb4=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(704x369:706x371)/jay-z-edf6090ede3c4547a47da0cf9c633778.jpg"
            },
            new Artist
            {
                Id = 20,
                Name = "Nicki Minaj",
                Bio = "Nicki Minaj is a hip hop and pop artist known for her bold personality and genre-bending hits.",
                Image = "https://media.npr.org/assets/img/2023/09/01/minaj_custom-b03a0992f23b6fe5d3d5add53c8920cd1b7e0c42.jpg"
            },
            new Artist
            {
                Id = 21,
                Name = "Cardi B",
                Bio = "Cardi B is a Grammy-winning rapper known for her energetic performances and charismatic personality.",
                Image = "https://globalnews.ca/wp-content/uploads/2023/07/GettyImages-1512301113.jpg?quality=85&strip=all&w=1200"
            },
    
            // R&B
            new Artist
            {
                Id = 22,
                Name = "Beyoncé",
                Bio = "Beyoncé is a global superstar and one of the most influential R&B artists of her generation.",
                Image = "https://media.glamour.com/photos/5cb7a1bf79e625ccc25b462c/master/pass/GettyImages-946416208.jpg"
            },
            new Artist
            {
                Id = 23,
                Name = "The Weeknd",
                Bio = "The Weeknd is a Canadian R&B singer known for his moody sound and chart-topping hits.",
                Image = "https://www.rollingstone.com/wp-content/uploads/2020/02/THE-WEEKND-by-Duncan-Loudon.jpg?w=1581&h=1054&crop=1"
            },
            new Artist
            {
                Id = 24,
                Name = "Frank Ocean",
                Bio = "Frank Ocean is an American singer-songwriter whose music combines R&B, soul, and alternative influences.",
                Image = "https://www.hollywoodinsider.com/wp-content/uploads/2020/09/Hollywood-Insider-Frank-Ocean-Letter-From-Fan.jpg"
            },
    
            // Alternative
            new Artist
            {
                Id = 25,
                Name = "Radiohead",
                Bio = "Radiohead is a British alternative rock band known for their experimental sound and boundary-pushing music.",
                Image = "https://images.bauerhosting.com/marketing/sites/16/2023/05/Radiohead-1995-hero.jpg?ar=16%3A9&fit=crop&crop=top&auto=format&w=undefined&q=80"
            },
            new Artist
            {
                Id = 26,
                Name = "The Killers",
                Bio = "The Killers are an American rock band whose music blends alternative rock, new wave, and synth-pop.",
                Image = "https://www.rollingstone.com/wp-content/uploads/2024/08/Photo-3-202106_The-Killers4981_no91_no6.jpg?w=1581&h=1054&crop=1"
            },
            new Artist
            {
                Id = 27,
                Name = "Arcade Fire",
                Bio = "Arcade Fire is a Canadian indie rock band known for their ambitious albums and eclectic sound.",
                Image = "https://i.guim.co.uk/img/media/da207ed976e1b316bab8a8ae547b6dbdc992911f/504_0_4674_2805/master/4674.jpg?width=1200&height=900&quality=85&auto=format&fit=crop&s=0f625bcdff3a9aede290d4cfa832dcfa"
            },
    
            // Punk
            new Artist
            {
                Id = 28,
                Name = "The Ramones",
                Bio = "The Ramones were a pioneering American punk rock band known for their fast, stripped-down sound.",
                Image = "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-226789-BPW2FR.jpg?w=1581&h=1054&crop=1"
            },
            new Artist
            {
                Id = 29,
                Name = "Green Day",
                Bio = "Green Day is an American punk rock band that brought punk back to the mainstream in the 1990s.",
                Image = "https://media.npr.org/assets/img/2024/01/29/green_day_hires-13_alice-baxley-applemusic-ef3e58054af3256bb65e4790038cb245758a6898.jpg"
            },
            new Artist
            {
                Id = 30,
                Name = "Sex Pistols",
                Bio = "The Sex Pistols were a British punk rock band known for their rebellious attitude and provocative music.",
                Image = "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-183232-85094733.jpg?w=1581&h=1054&crop=1"
            },
    
            // Emo
            new Artist
            {
                Id = 31,
                Name = "My Chemical Romance",
                Bio = "My Chemical Romance is an American rock band known for their emo and punk-inspired sound.",
                Image = "https://m.media-amazon.com/images/M/MV5BYmQwMTM1MTgtNDBhMy00ODY4LWFjOWItYzU4MGZkNmNhYzNiXkEyXkFqcGc@._V1_.jpg"
            },
            new Artist
            {
                Id = 32,
                Name = "Dashboard Confessional",
                Bio = "Dashboard Confessional is an American emo band known for their heartfelt lyrics and acoustic sound.",
                Image = "https://www.billboard.com/wp-content/uploads/media/Dashboard-Confessional-2020-cr-Dave-Bean-billboard-1548.jpg?w=1024"
            },
            new Artist
            {
                Id = 33,
                Name = "Fall Out Boy",
                Bio = "Fall Out Boy is an American rock band known for their blend of pop-punk, emo, and alternative rock.",
                Image = "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-179980-461150986.jpg?w=1581&h=1054&crop=1"
            },
    
            // Shoegaze
            new Artist
            {
                Id = 34,
                Name = "My Bloody Valentine",
                Bio = "My Bloody Valentine is an Irish-English band credited with pioneering the shoegaze genre with their swirling guitar effects.",
                Image = "https://d94thh4m1x8qv.cloudfront.net/eyJidWNrZXQiOiJkaXktbWFnYXppbmUiLCJrZXkiOiJkL2RpeS9BcnRpc3RzL00vTXktQmxvb2R5LVZhbGVudGluZS9QcmVzcy1zaG90LTIuanBnIiwiZWRpdHMiOnsianBlZyI6eyJxdWFsaXR5IjoxMDAsInByb2dyZXNzaXZlIjp0cnVlLCJ0cmVsbGlzUXVhbnRpc2F0aW9uIjp0cnVlLCJvdmVyc2hvb3REZXJpbmdpbmciOnRydWUsIm9wdGltaXplU2NhbnMiOnRydWV9LCJyZXNpemUiOnsid2lkdGgiOjE1MDAsImhlaWdodCI6MTAwMCwiZml0IjoiY292ZXIifX19"
            },
            new Artist
            {
                Id = 35,
                Name = "Slowdive",
                Bio = "Slowdive is a British shoegaze band known for their atmospheric sound and lush guitar textures.",
                Image = "https://heights-photos.s3.amazonaws.com/wp-content/uploads/2023/09/08003435/unnamed-1145x628.jpg"
            },
            new Artist
            {
                Id = 36,
                Name = "Ride",
                Bio = "Ride is an English shoegaze band whose blend of noise rock and ethereal vocals defined the genre's early years.",
                Image = "https://media.pitchfork.com/photos/592c55e70c2bba1b7de04698/master/pass/57dd23b1.jpg"
            },
    
            // Math Rock
            new Artist
            {
                Id = 37,
                Name = "American Football",
                Bio = "American Football is a band that blends math rock's technicality with the emotional depth of emo.",
                Image = "https://media.npr.org/assets/img/2016/10/11/americanfootballshervinlainezpress_wide-2fd88fc6a0049eb368b81d7ca0fed85bc55d1c2e.jpg"
            },
            new Artist
            {
                Id = 38,
                Name = "Toe",
                Bio = "Toe is a Japanese instrumental math rock band known for their intricate rhythms and emotive performances.",
                Image = "https://f4.bcbits.com/img/0004501051_10.jpg"
            },
            new Artist
            {
                Id = 39,
                Name = "TTNG (This Town Needs Guns)",
                Bio = "TTNG is a British math rock band known for their complex guitar work and shifting time signatures.",
                Image = "https://lastfm.freetls.fastly.net/i/u/ar0/066981738de4463080c3a02cc1bba55e.jpg"
            },
    
            // Prog Rock
            new Artist
            {
                Id = 40,
                Name = "Pink Floyd",
                Bio = "Pink Floyd is an iconic British progressive rock band known for their concept albums and psychedelic sound.",
                Image = "https://i.scdn.co/image/d011c95081cd9a329e506abd7ded47535d524a07"
            },
            new Artist
            {
                Id = 41,
                Name = "Yes",
                Bio = "Yes is a British prog rock band known for their complex compositions and virtuosic musicianship.",
                Image = "https://www.udiscovermusic.com/wp-content/uploads/2020/04/Yes-GettyImages-107731098-1.png"
            },
            new Artist
            {
                Id = 42,
                Name = "King Crimson",
                Bio = "King Crimson is a British prog rock band whose music pushed the boundaries of rock with experimental elements.",
                Image = "https://www.rollingstone.com/wp-content/uploads/2019/09/KingCrimson-1.jpg?w=1581&h=1054&crop=1"
            },
    
            // Classical
            new Artist
            {
                Id = 43,
                Name = "Ludwig van Beethoven",
                Bio = "Ludwig van Beethoven was a German composer and pianist whose work marked the transition between the Classical and Romantic eras.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Joseph_Karl_Stieler%27s_Beethoven_mit_dem_Manuskript_der_Missa_solemnis.jpg/1200px-Joseph_Karl_Stieler%27s_Beethoven_mit_dem_Manuskript_der_Missa_solemnis.jpg"
            },
            new Artist
            {
                Id = 44,
                Name = "Wolfgang Amadeus Mozart",
                Bio = "Mozart was a prolific and influential composer of the Classical era known for his symphonies, concertos, and operas.",
                Image = "https://cdn.britannica.com/35/74835-050-F0B71060/canvas-oil-Wolfgang-Amadeus-Mozart-Barbara-Krafft-1819.jpg"
            },
            new Artist
            {
                Id = 45,
                Name = "Johann Sebastian Bach",
                Bio = "Bach was a German composer and musician whose compositions are considered masterpieces of Baroque music.",
                Image = "https://upload.wikimedia.org/wikipedia/commons/6/6a/Johann_Sebastian_Bach.jpg"
            }
        };
    }
}