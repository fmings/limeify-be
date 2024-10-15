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
                Image = "https://example.com/images/tame_impala.png"
            },
            new Artist
            {
                Id = 2,
                Name = "Vampire Weekend",
                Bio = "Vampire Weekend is an American indie rock band known for blending baroque pop, African influences, and indie rock.",
                Image = "https://example.com/images/vampire_weekend.png"
            },
            new Artist
            {
                Id = 3,
                Name = "Phoebe Bridgers",
                Bio = "Phoebe Bridgers is an American indie singer-songwriter known for her introspective lyrics and haunting voice.",
                Image = "https://example.com/images/phoebe_bridgers.png"
            },
    
            // Country
            new Artist
            {
                Id = 4,
                Name = "Luke Combs",
                Bio = "Luke Combs is an American country singer-songwriter who has achieved rapid success with a blend of modern and traditional country sounds.",
                Image = "https://example.com/images/luke_combs.png"
            },
            new Artist
            {
                Id = 5,
                Name = "Carrie Underwood",
                Bio = "Carrie Underwood is a country music icon known for her powerful voice and chart-topping hits.",
                Image = "https://example.com/images/carrie_underwood.png"
            },
            new Artist
            {
                Id = 6,
                Name = "Kacey Musgraves",
                Bio = "Kacey Musgraves is a Grammy-winning country artist whose music bridges traditional and modern influences.",
                Image = "https://example.com/images/kacey_musgraves.png"
            },
    
            // Americana
            new Artist
            {
                Id = 7,
                Name = "Jason Isbell",
                Bio = "Jason Isbell is an Americana artist known for his powerful songwriting and contributions to modern southern rock.",
                Image = "https://example.com/images/jason_isbell.png"
            },
            new Artist
            {
                Id = 8,
                Name = "The Avett Brothers",
                Bio = "The Avett Brothers are a folk rock band whose music combines bluegrass, country, and punk influences.",
                Image = "https://example.com/images/avett_brothers.png"
            },
            new Artist
            {
                Id = 9,
                Name = "Brandi Carlile",
                Bio = "Brandi Carlile is an acclaimed Americana artist known for her emotive voice and genre-spanning songwriting.",
                Image = "https://example.com/images/brandi_carlile.png"
            },
    
            // Pop
            new Artist
            {
                Id = 10,
                Name = "Taylor Swift",
                Bio = "Taylor Swift is an American singer-songwriter whose career has spanned country, pop, and alternative genres.",
                Image = "https://example.com/images/taylor_swift.png"
            },
            new Artist
            {
                Id = 11,
                Name = "Ariana Grande",
                Bio = "Ariana Grande is a pop superstar known for her powerful vocals and chart-topping hits.",
                Image = "https://example.com/images/ariana_grande.png"
            },
            new Artist
            {
                Id = 12,
                Name = "Dua Lipa",
                Bio = "Dua Lipa is a British pop sensation known for her disco-inspired sound and dance-pop hits.",
                Image = "https://example.com/images/dua_lipa.png"
            },
    
            // Metal
            new Artist
            {
                Id = 13,
                Name = "Metallica",
                Bio = "Metallica is a legendary heavy metal band known for their aggressive sound and influence on the genre.",
                Image = "https://example.com/images/metallica.png"
            },
            new Artist
            {
                Id = 14,
                Name = "Iron Maiden",
                Bio = "Iron Maiden is a British heavy metal band known for their elaborate stage shows and complex compositions.",
                Image = "https://example.com/images/iron_maiden.png"
            },
            new Artist
            {
                Id = 15,
                Name = "Slipknot",
                Bio = "Slipknot is an American heavy metal band known for their intense live performances and masked personas.",
                Image = "https://example.com/images/slipknot.png"
            },
    
            // Rap
            new Artist
            {
                Id = 16,
                Name = "Kendrick Lamar",
                Bio = "Kendrick Lamar is a Pulitzer Prize-winning rapper known for his socially conscious lyrics and innovative sound.",
                Image = "https://example.com/images/kendrick_lamar.png"
            },
            new Artist
            {
                Id = 17,
                Name = "Drake",
                Bio = "Drake is a Canadian rapper and singer whose music blends rap, R&B, and pop influences.",
                Image = "https://example.com/images/drake.png"
            },
            new Artist
            {
                Id = 18,
                Name = "J. Cole",
                Bio = "J. Cole is an American rapper and producer known for his introspective lyrics and storytelling ability.",
                Image = "https://example.com/images/j_cole.png"
            },
    
            // Hip Hop
            new Artist
            {
                Id = 19,
                Name = "Jay-Z",
                Bio = "Jay-Z is a hip hop mogul and one of the most influential rappers of all time.",
                Image = "https://example.com/images/jay_z.png"
            },
            new Artist
            {
                Id = 20,
                Name = "Nicki Minaj",
                Bio = "Nicki Minaj is a hip hop and pop artist known for her bold personality and genre-bending hits.",
                Image = "https://example.com/images/nicki_minaj.png"
            },
            new Artist
            {
                Id = 21,
                Name = "Cardi B",
                Bio = "Cardi B is a Grammy-winning rapper known for her energetic performances and charismatic personality.",
                Image = "https://example.com/images/cardi_b.png"
            },
    
            // R&B
            new Artist
            {
                Id = 22,
                Name = "Beyoncé",
                Bio = "Beyoncé is a global superstar and one of the most influential R&B artists of her generation.",
                Image = "https://example.com/images/beyonce.png"
            },
            new Artist
            {
                Id = 23,
                Name = "The Weeknd",
                Bio = "The Weeknd is a Canadian R&B singer known for his moody sound and chart-topping hits.",
                Image = "https://example.com/images/the_weeknd.png"
            },
            new Artist
            {
                Id = 24,
                Name = "Frank Ocean",
                Bio = "Frank Ocean is an American singer-songwriter whose music combines R&B, soul, and alternative influences.",
                Image = "https://example.com/images/frank_ocean.png"
            },
    
            // Alternative
            new Artist
            {
                Id = 25,
                Name = "Radiohead",
                Bio = "Radiohead is a British alternative rock band known for their experimental sound and boundary-pushing music.",
                Image = "https://example.com/images/radiohead.png"
            },
            new Artist
            {
                Id = 26,
                Name = "The Killers",
                Bio = "The Killers are an American rock band whose music blends alternative rock, new wave, and synth-pop.",
                Image = "https://example.com/images/the_killers.png"
            },
            new Artist
            {
                Id = 27,
                Name = "Arcade Fire",
                Bio = "Arcade Fire is a Canadian indie rock band known for their ambitious albums and eclectic sound.",
                Image = "https://example.com/images/arcade_fire.png"
            },
    
            // Punk
            new Artist
            {
                Id = 28,
                Name = "The Ramones",
                Bio = "The Ramones were a pioneering American punk rock band known for their fast, stripped-down sound.",
                Image = "https://example.com/images/the_ramones.png"
            },
            new Artist
            {
                Id = 29,
                Name = "Green Day",
                Bio = "Green Day is an American punk rock band that brought punk back to the mainstream in the 1990s.",
                Image = "https://example.com/images/green_day.png"
            },
            new Artist
            {
                Id = 30,
                Name = "Sex Pistols",
                Bio = "The Sex Pistols were a British punk rock band known for their rebellious attitude and provocative music.",
                Image = "https://example.com/images/sex_pistols.png"
            },
    
            // Emo
            new Artist
            {
                Id = 31,
                Name = "My Chemical Romance",
                Bio = "My Chemical Romance is an American rock band known for their emo and punk-inspired sound.",
                Image = "https://example.com/images/my_chemical_romance.png"
            },
            new Artist
            {
                Id = 32,
                Name = "Dashboard Confessional",
                Bio = "Dashboard Confessional is an American emo band known for their heartfelt lyrics and acoustic sound.",
                Image = "https://example.com/images/dashboard_confessional.png"
            },
            new Artist
            {
                Id = 33,
                Name = "Fall Out Boy",
                Bio = "Fall Out Boy is an American rock band known for their blend of pop-punk, emo, and alternative rock.",
                Image = "https://example.com/images/fall_out_boy.png"
            },
    
            // Shoegaze
            new Artist
            {
                Id = 34,
                Name = "My Bloody Valentine",
                Bio = "My Bloody Valentine is an Irish-English band credited with pioneering the shoegaze genre with their swirling guitar effects.",
                Image = "https://example.com/images/my_bloody_valentine.png"
            },
            new Artist
            {
                Id = 35,
                Name = "Slowdive",
                Bio = "Slowdive is a British shoegaze band known for their atmospheric sound and lush guitar textures.",
                Image = "https://example.com/images/slowdive.png"
            },
            new Artist
            {
                Id = 36,
                Name = "Ride",
                Bio = "Ride is an English shoegaze band whose blend of noise rock and ethereal vocals defined the genre's early years.",
                Image = "https://example.com/images/ride.png"
            },
    
            // Math Rock
            new Artist
            {
                Id = 37,
                Name = "American Football",
                Bio = "American Football is a band that blends math rock's technicality with the emotional depth of emo.",
                Image = "https://example.com/images/american_football.png"
            },
            new Artist
            {
                Id = 38,
                Name = "Toe",
                Bio = "Toe is a Japanese instrumental math rock band known for their intricate rhythms and emotive performances.",
                Image = "https://example.com/images/toe.png"
            },
            new Artist
            {
                Id = 39,
                Name = "TTNG (This Town Needs Guns)",
                Bio = "TTNG is a British math rock band known for their complex guitar work and shifting time signatures.",
                Image = "https://example.com/images/ttng.png"
            },
    
            // Prog Rock
            new Artist
            {
                Id = 40,
                Name = "Pink Floyd",
                Bio = "Pink Floyd is an iconic British progressive rock band known for their concept albums and psychedelic sound.",
                Image = "https://example.com/images/pink_floyd.png"
            },
            new Artist
            {
                Id = 41,
                Name = "Yes",
                Bio = "Yes is a British prog rock band known for their complex compositions and virtuosic musicianship.",
                Image = "https://example.com/images/yes.png"
            },
            new Artist
            {
                Id = 42,
                Name = "King Crimson",
                Bio = "King Crimson is a British prog rock band whose music pushed the boundaries of rock with experimental elements.",
                Image = "https://example.com/images/king_crimson.png"
            },
    
            // Classical
            new Artist
            {
                Id = 43,
                Name = "Ludwig van Beethoven",
                Bio = "Ludwig van Beethoven was a German composer and pianist whose work marked the transition between the Classical and Romantic eras.",
                Image = "https://example.com/images/beethoven.png"
            },
            new Artist
            {
                Id = 44,
                Name = "Wolfgang Amadeus Mozart",
                Bio = "Mozart was a prolific and influential composer of the Classical era known for his symphonies, concertos, and operas.",
                Image = "https://example.com/images/mozart.png"
            },
            new Artist
            {
                Id = 45,
                Name = "Johann Sebastian Bach",
                Bio = "Bach was a German composer and musician whose compositions are considered masterpieces of Baroque music.",
                Image = "https://example.com/images/bach.png"
            }
        };
    }
}