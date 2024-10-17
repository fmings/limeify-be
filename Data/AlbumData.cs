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
                Image = "https://upload.wikimedia.org/wikipedia/en/9/9b/Tame_Impala_-_Currents.png",
                ArtistId = 1,  // Tame Impala
                GenreId = 1    // Indie
            },
            new Album
            {
                Id = 2,
                Name = "Father of the Bride",
                Year = 2019,
                Image = "https://t2.genius.com/unsafe/383x0/https%3A%2F%2Fimages.genius.com%2F5f9a6674593806ac72677141c0e66330.1000x1000x1.png",
                ArtistId = 2,  // Vampire Weekend
                GenreId = 1    // Indie
            },
            new Album
            {
                Id = 3,
                Name = "Punisher",
                Year = 2020,
                Image = "https://upload.wikimedia.org/wikipedia/en/2/23/Phoebe_Bridgers_Punisher_%282020%29.png",
                ArtistId = 3,  // Phoebe Bridgers
                GenreId = 1    // Indie
            },

            // Country
            new Album
            {
                Id = 4,
                Name = "What You See Is What You Get",
                Year = 2019,
                Image = "https://upload.wikimedia.org/wikipedia/en/e/e3/Luke_Combs_-_What_You_See_Is_What_You_Get.png",
                ArtistId = 4,  // Luke Combs
                GenreId = 2    // Country
            },
            new Album
            {
                Id = 5,
                Name = "Cry Pretty",
                Year = 2018,
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/d/dc/Carrie_Underwood_-_Cry_Pretty_%28Official_Album_Cover%29.png/220px-Carrie_Underwood_-_Cry_Pretty_%28Official_Album_Cover%29.png",
                ArtistId = 5,  // Carrie Underwood
                GenreId = 2    // Country
            },
            new Album
            {
                Id = 6,
                Name = "Golden Hour",
                Year = 2018,
                Image = "https://upload.wikimedia.org/wikipedia/en/6/65/Kacey_Musgraves_-_Golden_Hour.png",
                ArtistId = 6,  // Kacey Musgraves
                GenreId = 2    // Country
            },

            // Americana
            new Album
            {
                Id = 7,
                Name = "Southeastern",
                Year = 2013,
                Image = "https://upload.wikimedia.org/wikipedia/en/c/c5/Southeasternjasonisbell.jpg",
                ArtistId = 7,  // Jason Isbell
                GenreId = 3    // Americana
            },
            new Album
            {
                Id = 8,
                Name = "The Carpenter",
                Year = 2012,
                Image = "https://upload.wikimedia.org/wikipedia/en/1/18/The_Carpenter_%28The_Avett_Brothers%29_cover_art.jpg",
                ArtistId = 8,  // The Avett Brothers
                GenreId = 3    // Americana
            },
            new Album
            {
                Id = 9,
                Name = "By the Way, I Forgive You",
                Year = 2018,
                Image = "https://upload.wikimedia.org/wikipedia/en/e/ec/By_the_Way%2C_I_Forgive_You_-_Brandi_Carlile.png",
                ArtistId = 9,  // Brandi Carlile
                GenreId = 3    // Americana
            },

            // Pop
            new Album
            {
                Id = 10,
                Name = "1989",
                Year = 2014,
                Image = "https://upload.wikimedia.org/wikipedia/en/f/f6/Taylor_Swift_-_1989.png",
                ArtistId = 10,  // Taylor Swift
                GenreId = 4     // Pop
            },
            new Album
            {
                Id = 11,
                Name = "Positions",
                Year = 2020,
                Image = "https://upload.wikimedia.org/wikipedia/en/a/a0/Ariana_Grande_-_Positions.png",
                ArtistId = 11,  // Ariana Grande
                GenreId = 4     // Pop
            },
            new Album
            {
                Id = 12,
                Name = "Future Nostalgia",
                Year = 2020,
                Image = "https://upload.wikimedia.org/wikipedia/en/f/f5/Dua_Lipa_-_Future_Nostalgia_%28Official_Album_Cover%29.png",
                ArtistId = 12,  // Dua Lipa
                GenreId = 4     // Pop
            },

            // Metal
            new Album
            {
                Id = 13,
                Name = "Master of Puppets",
                Year = 1986,
                Image = "https://upload.wikimedia.org/wikipedia/en/b/b2/Metallica_-_Master_of_Puppets_cover.jpg",
                ArtistId = 13,  // Metallica
                GenreId = 5     // Metal
            },
            new Album
            {
                Id = 14,
                Name = "The Number of the Beast",
                Year = 1982,
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/3/32/IronMaiden_NumberOfBeast.jpg/220px-IronMaiden_NumberOfBeast.jpg",
                ArtistId = 14,  // Iron Maiden
                GenreId = 5     // Metal
            },
            new Album
            {
                Id = 15,
                Name = "Iowa",
                Year = 2001,
                Image = "https://upload.wikimedia.org/wikipedia/en/1/1d/Slipknot_Iowa.jpg",
                ArtistId = 15,  // Slipknot
                GenreId = 5     // Metal
            },

            // Rap
            new Album
            {
                Id = 16,
                Name = "To Pimp a Butterfly",
                Year = 2015,
                Image = "https://upload.wikimedia.org/wikipedia/en/f/f6/Kendrick_Lamar_-_To_Pimp_a_Butterfly.png",
                ArtistId = 16,  // Kendrick Lamar
                GenreId = 6     // Rap
            },
            new Album
            {
                Id = 17,
                Name = "Scorpion",
                Year = 2018,
                Image = "https://upload.wikimedia.org/wikipedia/en/9/90/Scorpion_by_Drake.jpg",
                ArtistId = 17,  // Drake
                GenreId = 6     // Rap
            },
            new Album
            {
                Id = 18,
                Name = "2014 Forest Hills Drive",
                Year = 2014,
                Image = "https://upload.wikimedia.org/wikipedia/en/2/2a/2014ForestHillsDrive.jpg",
                ArtistId = 18,  // J. Cole
                GenreId = 6     // Rap
            },

            // Hip Hop
            new Album
            {
                Id = 19,
                Name = "The Blueprint",
                Year = 2001,
                Image = "https://upload.wikimedia.org/wikipedia/en/2/2c/The_Blueprint.png",
                ArtistId = 19,  // Jay-Z
                GenreId = 7     // Hip Hop
            },
            new Album
            {
                Id = 20,
                Name = "Queen",
                Year = 2018,
                Image = "https://i.pinimg.com/736x/91/06/66/910666f35cc2c190e585bdda709567fc.jpg",
                ArtistId = 20,  // Nicki Minaj
                GenreId = 7     // Hip Hop
            },
            new Album
            {
                Id = 21,
                Name = "Invasion of Privacy",
                Year = 2018,
                Image = "https://upload.wikimedia.org/wikipedia/en/9/97/Cardi_B_-_Invasion_of_Privacy.png",
                ArtistId = 21,  // Cardi B
                GenreId = 7     // Hip Hop
            },

            // R&B
            new Album
            {
                Id = 22,
                Name = "Lemonade",
                Year = 2016,
                Image = "https://upload.wikimedia.org/wikipedia/en/5/53/Beyonce_-_Lemonade_%28Official_Album_Cover%29.png",
                ArtistId = 22,  // Beyoncé
                GenreId = 8     // R&B
            },
            new Album
            {
                Id = 23,
                Name = "After Hours",
                Year = 2020,
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/c/c1/The_Weeknd_-_After_Hours.png/220px-The_Weeknd_-_After_Hours.png",
                ArtistId = 23,  // The Weeknd
                GenreId = 8     // R&B
            },
            new Album
            {
                Id = 24,
                Name = "Blonde",
                Year = 2016,
                Image = "https://upload.wikimedia.org/wikipedia/en/a/a0/Blonde_-_Frank_Ocean.jpeg",
                ArtistId = 24,  // Frank Ocean
                GenreId = 8     // R&B
            },

            // Alternative
            new Album
            {
                Id = 25,
                Name = "OK Computer",
                Year = 1997,
                Image = "https://upload.wikimedia.org/wikipedia/en/b/ba/Radioheadokcomputer.png",
                ArtistId = 25,  // Radiohead
                GenreId = 9     // Alternative
            },
            new Album
            {
                Id = 26,
                Name = "Hot Fuss",
                Year = 2004,
                Image = "https://upload.wikimedia.org/wikipedia/en/1/17/The_Killers_-_Hot_Fuss.png",
                ArtistId = 26,  // The Killers
                GenreId = 9     // Alternative
            },
            new Album
            {
                Id = 27,
                Name = "The Suburbs",
                Year = 2010,
                Image = "https://upload.wikimedia.org/wikipedia/en/8/81/Arcade_Fire_-_The_Suburbs.jpg",
                ArtistId = 27,  // Arcade Fire
                GenreId = 9     // Alternative
            },

            // Punk
            new Album
            {
                Id = 28,
                Name = "Ramones",
                Year = 1976,
                Image = "https://m.media-amazon.com/images/I/81m8mrMsfAL._UF1000,1000_QL80_.jpg",
                ArtistId = 28,  // The Ramones
                GenreId = 10    // Punk
            },
            new Album
            {
                Id = 29,
                Name = "Dookie",
                Year = 1994,
                Image = "https://upload.wikimedia.org/wikipedia/en/4/4b/Green_Day_-_Dookie_cover.jpg",
                ArtistId = 29,  // Green Day
                GenreId = 10    // Punk
            },
            new Album
            {
                Id = 30,
                Name = "London Calling",
                Year = 1979,
                Image = "https://upload.wikimedia.org/wikipedia/en/0/00/TheClashLondonCallingalbumcover.jpg",
                ArtistId = 30,  // The Clash
                GenreId = 10    // Punk
            },

            // Emo
            new Album
            {
                Id = 31,
                Name = "The Black Parade",
                Year = 2006,
                Image = "https://upload.wikimedia.org/wikipedia/en/e/ea/Blackparadecover.jpg",
                ArtistId = 31,  // My Chemical Romance
                GenreId = 11    // Emo
            },
            new Album
            {
                Id = 32,
                Name = "Deja Entendu",
                Year = 2003,
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/7/7b/Brand_New_Deja_Entendu.jpg/220px-Brand_New_Deja_Entendu.jpg",
                ArtistId = 32,  // Brand New
                GenreId = 11    // Emo
            },
            new Album
            {
                Id = 33,
                Name = "From Under the Cork Tree",
                Year = 2005,
                Image = "https://upload.wikimedia.org/wikipedia/en/0/00/Fall_Out_Boy_-_From_Under_the_Cork_Tree_-_CD_album_cover.jpg",
                ArtistId = 33,  // Fall Out Boy
                GenreId = 11    // Emo
            },

            // Shoegaze
            new Album
            {
                Id = 34,
                Name = "Loveless",
                Year = 1991,
                Image = "https://upload.wikimedia.org/wikipedia/en/4/4b/My_Bloody_Valentine_-_Loveless.png",
                ArtistId = 34,  // My Bloody Valentine
                GenreId = 12    // Shoegaze
            },
            new Album
            {
                Id = 35,
                Name = "Souvlaki",
                Year = 1993,
                Image = "https://upload.wikimedia.org/wikipedia/en/a/a6/Souvlaki_%28album%29_cover.jpg",
                ArtistId = 35,  // Slowdive
                GenreId = 12    // Shoegaze
            },
            new Album
            {
                Id = 36,
                Name = "Nowhere",
                Year = 1990,
                Image = "https://upload.wikimedia.org/wikipedia/en/9/9b/Nowhereridecover.jpg",
                ArtistId = 36,  // Ride
                GenreId = 12    // Shoegaze
            },

            // Math Rock
            new Album
            {
                Id = 37,
                Name = "American Football",
                Year = 1999,
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/e/e6/American_football_band_lp_cover.png/220px-American_football_band_lp_cover.png",
                ArtistId = 37,  // American Football
                GenreId = 13    // Math Rock
            },
            new Album
            {
                Id = 38,
                Name = "For Long Tomorrow",
                Year = 2009,
                Image = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d0/For_Long_Tomorrow.jpg/220px-For_Long_Tomorrow.jpg",
                ArtistId = 38,  // Toe
                GenreId = 13    // Math Rock
            },
            new Album
            {
                Id = 39,
                Name = "Animals",
                Year = 2008,
                Image = "https://upload.wikimedia.org/wikipedia/en/8/8f/Animals_%28This_Town_Needs_Guns_album%29.jpeg",
                ArtistId = 39,  // TTNG
                GenreId = 13    // Math Rock
            },

            // Prog Rock
            new Album
            {
                Id = 40,
                Name = "The Dark Side of the Moon",
                Year = 1973,
                Image = "https://t2.gstatic.com/licensed-image?q=tbn:ANd9GcT9kry1myZTi2dMJ7OtgJjmdT__lImpI-pJ9mdq42Cz8HhIet_ro_Obp6q4xbksBbpT",
                ArtistId = 40,  // Pink Floyd
                GenreId = 14    // Prog Rock
            },
            new Album
            {
                Id = 41,
                Name = "Close to the Edge",
                Year = 1972,
                Image = "https://upload.wikimedia.org/wikipedia/en/0/09/Yes-close.jpg",
                ArtistId = 41,  // Yes
                GenreId = 14    // Prog Rock
            },
            new Album
            {
                Id = 42,
                Name = "In the Court of the Crimson King",
                Year = 1969,
                Image = "https://upload.wikimedia.org/wikipedia/en/8/84/In_the_Court_of_the_Crimson_King_-_40th_Anniversary_Box_Set_-_Front_cover.jpeg",
                ArtistId = 42,  // King Crimson
                GenreId = 14    // Prog Rock
            },

            // Classical
            new Album
            {
                Id = 43,
                Name = "Symphony No. 9",
                Year = 1824,
                Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/Ninth_Symphony_original.png/1200px-Ninth_Symphony_original.png",
                ArtistId = 43,  // Ludwig van Beethoven
                GenreId = 15    // Classical
            },
            new Album
            {
                Id = 44,
                Name = "The Magic Flute",
                Year = 1791,
                Image = "https://upload.wikimedia.org/wikipedia/commons/3/3e/Mozart_magic_flute.jpg",
                ArtistId = 44,  // Wolfgang Amadeus Mozart
                GenreId = 15    // Classical
            },
            new Album
            {
                Id = 45,
                Name = "The Well-Tempered Clavier",
                Year = 1722,
                Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDbK128Dg3CQyAyUSp-wgXsA4gfSSTYxFf0g&s",
                ArtistId = 45,  // Johann Sebastian Bach
                GenreId = 15    // Classical
            }
        };
    }
}