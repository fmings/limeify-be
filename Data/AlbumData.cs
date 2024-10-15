using Limeify.Models;

namespace Limeify.Data
{
    public class AlbumData
    {
        public static List<Album> Albums = new()
        {
            // Indie
            new Album
            {
                Id = 1,
                Name = "Currents",
                Year = 2015,
                Image = "https://example.com/images/currents.png",
                ArtistId = 1,  // Tame Impala
                GenreId = 1    // Indie
            },
            new Album
            {
                Id = 2,
                Name = "Father of the Bride",
                Year = 2019,
                Image = "https://example.com/images/father_of_the_bride.png",
                ArtistId = 2,  // Vampire Weekend
                GenreId = 1    // Indie
            },
            new Album
            {
                Id = 3,
                Name = "Punisher",
                Year = 2020,
                Image = "https://example.com/images/punisher.png",
                ArtistId = 3,  // Phoebe Bridgers
                GenreId = 1    // Indie
            },

            // Country
            new Album
            {
                Id = 4,
                Name = "What You See Is What You Get",
                Year = 2019,
                Image = "https://example.com/images/what_you_see.png",
                ArtistId = 4,  // Luke Combs
                GenreId = 2    // Country
            },
            new Album
            {
                Id = 5,
                Name = "Cry Pretty",
                Year = 2018,
                Image = "https://example.com/images/cry_pretty.png",
                ArtistId = 5,  // Carrie Underwood
                GenreId = 2    // Country
            },
            new Album
            {
                Id = 6,
                Name = "Golden Hour",
                Year = 2018,
                Image = "https://example.com/images/golden_hour.png",
                ArtistId = 6,  // Kacey Musgraves
                GenreId = 2    // Country
            },

            // Americana
            new Album
            {
                Id = 7,
                Name = "Southeastern",
                Year = 2013,
                Image = "https://example.com/images/southeastern.png",
                ArtistId = 7,  // Jason Isbell
                GenreId = 3    // Americana
            },
            new Album
            {
                Id = 8,
                Name = "The Carpenter",
                Year = 2012,
                Image = "https://example.com/images/the_carpenter.png",
                ArtistId = 8,  // The Avett Brothers
                GenreId = 3    // Americana
            },
            new Album
            {
                Id = 9,
                Name = "By the Way, I Forgive You",
                Year = 2018,
                Image = "https://example.com/images/by_the_way.png",
                ArtistId = 9,  // Brandi Carlile
                GenreId = 3    // Americana
            },

            // Pop
            new Album
            {
                Id = 10,
                Name = "1989",
                Year = 2014,
                Image = "https://example.com/images/1989.png",
                ArtistId = 10,  // Taylor Swift
                GenreId = 4     // Pop
            },
            new Album
            {
                Id = 11,
                Name = "Positions",
                Year = 2020,
                Image = "https://example.com/images/positions.png",
                ArtistId = 11,  // Ariana Grande
                GenreId = 4     // Pop
            },
            new Album
            {
                Id = 12,
                Name = "Future Nostalgia",
                Year = 2020,
                Image = "https://example.com/images/future_nostalgia.png",
                ArtistId = 12,  // Dua Lipa
                GenreId = 4     // Pop
            },

            // Metal
            new Album
            {
                Id = 13,
                Name = "Master of Puppets",
                Year = 1986,
                Image = "https://example.com/images/master_of_puppets.png",
                ArtistId = 13,  // Metallica
                GenreId = 5     // Metal
            },
            new Album
            {
                Id = 14,
                Name = "The Number of the Beast",
                Year = 1982,
                Image = "https://example.com/images/number_of_the_beast.png",
                ArtistId = 14,  // Iron Maiden
                GenreId = 5     // Metal
            },
            new Album
            {
                Id = 15,
                Name = "Iowa",
                Year = 2001,
                Image = "https://example.com/images/iowa.png",
                ArtistId = 15,  // Slipknot
                GenreId = 5     // Metal
            },

            // Rap
            new Album
            {
                Id = 16,
                Name = "To Pimp a Butterfly",
                Year = 2015,
                Image = "https://example.com/images/to_pimp_a_butterfly.png",
                ArtistId = 16,  // Kendrick Lamar
                GenreId = 6     // Rap
            },
            new Album
            {
                Id = 17,
                Name = "Scorpion",
                Year = 2018,
                Image = "https://example.com/images/scorpion.png",
                ArtistId = 17,  // Drake
                GenreId = 6     // Rap
            },
            new Album
            {
                Id = 18,
                Name = "2014 Forest Hills Drive",
                Year = 2014,
                Image = "https://example.com/images/forest_hills_drive.png",
                ArtistId = 18,  // J. Cole
                GenreId = 6     // Rap
            },

            // Hip Hop
            new Album
            {
                Id = 19,
                Name = "The Blueprint",
                Year = 2001,
                Image = "https://example.com/images/blueprint.png",
                ArtistId = 19,  // Jay-Z
                GenreId = 7     // Hip Hop
            },
            new Album
            {
                Id = 20,
                Name = "Queen",
                Year = 2018,
                Image = "https://example.com/images/queen.png",
                ArtistId = 20,  // Nicki Minaj
                GenreId = 7     // Hip Hop
            },
            new Album
            {
                Id = 21,
                Name = "Invasion of Privacy",
                Year = 2018,
                Image = "https://example.com/images/invasion_of_privacy.png",
                ArtistId = 21,  // Cardi B
                GenreId = 7     // Hip Hop
            },

            // R&B
            new Album
            {
                Id = 22,
                Name = "Lemonade",
                Year = 2016,
                Image = "https://example.com/images/lemonade.png",
                ArtistId = 22,  // Beyoncé
                GenreId = 8     // R&B
            },
            new Album
            {
                Id = 23,
                Name = "After Hours",
                Year = 2020,
                Image = "https://example.com/images/after_hours.png",
                ArtistId = 23,  // The Weeknd
                GenreId = 8     // R&B
            },
            new Album
            {
                Id = 24,
                Name = "Blonde",
                Year = 2016,
                Image = "https://example.com/images/blonde.png",
                ArtistId = 24,  // Frank Ocean
                GenreId = 8     // R&B
            },

            // Alternative
            new Album
            {
                Id = 25,
                Name = "OK Computer",
                Year = 1997,
                Image = "https://example.com/images/ok_computer.png",
                ArtistId = 25,  // Radiohead
                GenreId = 9     // Alternative
            },
            new Album
            {
                Id = 26,
                Name = "Hot Fuss",
                Year = 2004,
                Image = "https://example.com/images/hot_fuss.png",
                ArtistId = 26,  // The Killers
                GenreId = 9     // Alternative
            },
            new Album
            {
                Id = 27,
                Name = "The Suburbs",
                Year = 2010,
                Image = "https://example.com/images/the_suburbs.png",
                ArtistId = 27,  // Arcade Fire
                GenreId = 9     // Alternative
            },

            // Punk
            new Album
            {
                Id = 28,
                Name = "Ramones",
                Year = 1976,
                Image = "https://example.com/images/ramones.png",
                ArtistId = 28,  // The Ramones
                GenreId = 10    // Punk
            },
            new Album
            {
                Id = 29,
                Name = "Dookie",
                Year = 1994,
                Image = "https://example.com/images/dookie.png",
                ArtistId = 29,  // Green Day
                GenreId = 10    // Punk
            },
            new Album
            {
                Id = 30,
                Name = "London Calling",
                Year = 1979,
                Image = "https://example.com/images/london_calling.png",
                ArtistId = 30,  // The Clash
                GenreId = 10    // Punk
            },

            // Emo
            new Album
            {
                Id = 31,
                Name = "The Black Parade",
                Year = 2006,
                Image = "https://example.com/images/black_parade.png",
                ArtistId = 31,  // My Chemical Romance
                GenreId = 11    // Emo
            },
            new Album
            {
                Id = 32,
                Name = "Deja Entendu",
                Year = 2003,
                Image = "https://example.com/images/deja_entendu.png",
                ArtistId = 32,  // Brand New
                GenreId = 11    // Emo
            },
            new Album
            {
                Id = 33,
                Name = "From Under the Cork Tree",
                Year = 2005,
                Image = "https://example.com/images/cork_tree.png",
                ArtistId = 33,  // Fall Out Boy
                GenreId = 11    // Emo
            },

            // Shoegaze
            new Album
            {
                Id = 34,
                Name = "Loveless",
                Year = 1991,
                Image = "https://example.com/images/loveless.png",
                ArtistId = 34,  // My Bloody Valentine
                GenreId = 12    // Shoegaze
            },
            new Album
            {
                Id = 35,
                Name = "Souvlaki",
                Year = 1993,
                Image = "https://example.com/images/souvlaki.png",
                ArtistId = 35,  // Slowdive
                GenreId = 12    // Shoegaze
            },
            new Album
            {
                Id = 36,
                Name = "Nowhere",
                Year = 1990,
                Image = "https://example.com/images/nowhere.png",
                ArtistId = 36,  // Ride
                GenreId = 12    // Shoegaze
            },

            // Math Rock
            new Album
            {
                Id = 37,
                Name = "American Football",
                Year = 1999,
                Image = "https://example.com/images/american_football.png",
                ArtistId = 37,  // American Football
                GenreId = 13    // Math Rock
            },
            new Album
            {
                Id = 38,
                Name = "For Long Tomorrow",
                Year = 2009,
                Image = "https://example.com/images/for_long_tomorrow.png",
                ArtistId = 38,  // Toe
                GenreId = 13    // Math Rock
            },
            new Album
            {
                Id = 39,
                Name = "Animals",
                Year = 2008,
                Image = "https://example.com/images/animals.png",
                ArtistId = 39,  // TTNG
                GenreId = 13    // Math Rock
            },

            // Prog Rock
            new Album
            {
                Id = 40,
                Name = "The Dark Side of the Moon",
                Year = 1973,
                Image = "https://example.com/images/dark_side.png",
                ArtistId = 40,  // Pink Floyd
                GenreId = 14    // Prog Rock
            },
            new Album
            {
                Id = 41,
                Name = "Close to the Edge",
                Year = 1972,
                Image = "https://example.com/images/close_to_the_edge.png",
                ArtistId = 41,  // Yes
                GenreId = 14    // Prog Rock
            },
            new Album
            {
                Id = 42,
                Name = "In the Court of the Crimson King",
                Year = 1969,
                Image = "https://example.com/images/crimson_king.png",
                ArtistId = 42,  // King Crimson
                GenreId = 14    // Prog Rock
            },

            // Classical
            new Album
            {
                Id = 43,
                Name = "Symphony No. 9",
                Year = 1824,
                Image = "https://example.com/images/symphony_9.png",
                ArtistId = 43,  // Ludwig van Beethoven
                GenreId = 15    // Classical
            },
            new Album
            {
                Id = 44,
                Name = "The Magic Flute",
                Year = 1791,
                Image = "https://example.com/images/magic_flute.png",
                ArtistId = 44,  // Wolfgang Amadeus Mozart
                GenreId = 15    // Classical
            },
            new Album
            {
                Id = 45,
                Name = "The Well-Tempered Clavier",
                Year = 1722,
                Image = "https://example.com/images/well_tempered_clavier.png",
                ArtistId = 45,  // Johann Sebastian Bach
                GenreId = 15    // Classical
            }
        };
    }
}