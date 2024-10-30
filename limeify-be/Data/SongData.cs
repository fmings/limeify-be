using Limeify.Models;

namespace Limeify.Data
{
    public class SongData
    {
        public static List<Song> Songs = new()
        {
            // Indie
            new Song
            {
                Id = 1,
                Name = "Let It Happen",
                ArtistId = 1,  // Tame Impala
                AlbumId = 1,   // Currents
                GenreId = 1,   // Indie
                Length = 418
            },
            new Song
            {
                Id = 2,
                Name = "Harmony Hall",
                ArtistId = 2,  // Vampire Weekend
                AlbumId = 2,   // Father of the Bride
                GenreId = 1,   // Indie
                Length = 257
            },
            new Song
            {
                Id = 3,
                Name = "Kyoto",
                ArtistId = 3,  // Phoebe Bridgers
                AlbumId = 3,   // Punisher
                GenreId = 1,   // Indie
                Length = 265
            },

            // Country
            new Song
            {
                Id = 4,
                Name = "Beer Never Broke My Heart",
                ArtistId = 4,  // Luke Combs
                AlbumId = 4,   // What You See Is What You Get
                GenreId = 2,   // Country
                Length = 203
            },
            new Song
            {
                Id = 5,
                Name = "Cry Pretty",
                ArtistId = 5,  // Carrie Underwood
                AlbumId = 5,   // Cry Pretty
                GenreId = 2,   // Country
                Length = 228
            },
            new Song
            {
                Id = 6,
                Name = "Butterflies",
                ArtistId = 6,  // Kacey Musgraves
                AlbumId = 6,   // Golden Hour
                GenreId = 2,   // Country
                Length = 194
            },

            // Americana
            new Song
            {
                Id = 7,
                Name = "Cover Me Up",
                ArtistId = 7,  // Jason Isbell
                AlbumId = 7,   // Southeastern
                GenreId = 3,   // Americana
                Length = 265
            },
            new Song
            {
                Id = 8,
                Name = "I and Love and You",
                ArtistId = 8,  // The Avett Brothers
                AlbumId = 8,   // The Carpenter
                GenreId = 3,   // Americana
                Length = 223
            },
            new Song
            {
                Id = 9,
                Name = "The Joke",
                ArtistId = 9,  // Brandi Carlile
                AlbumId = 9,   // By the Way, I Forgive You
                GenreId = 3,   // Americana
                Length = 268
            },

            // Pop
            new Song
            {
                Id = 10,
                Name = "Shake It Off",
                ArtistId = 10,  // Taylor Swift
                AlbumId = 10,   // 1989
                GenreId = 4,    // Pop
                Length = 219
            },
            new Song
            {
                Id = 11,
                Name = "7 rings",
                ArtistId = 11,  // Ariana Grande
                AlbumId = 11,   // Positions
                GenreId = 4,    // Pop
                Length = 182
            },
            new Song
            {
                Id = 12,
                Name = "Don't Start Now",
                ArtistId = 12,  // Dua Lipa
                AlbumId = 12,   // Future Nostalgia
                GenreId = 4,    // Pop
                Length = 183
            },

            // Metal
            new Song
            {
                Id = 13,
                Name = "Enter Sandman",
                ArtistId = 13,  // Metallica
                AlbumId = 13,   // Master of Puppets
                GenreId = 5,    // Metal
                Length = 331
            },
            new Song
            {
                Id = 14,
                Name = "The Trooper",
                ArtistId = 14,  // Iron Maiden
                AlbumId = 14,   // The Number of the Beast
                GenreId = 5,    // Metal
                Length = 240
            },
            new Song
            {
                Id = 15,
                Name = "Duality",
                ArtistId = 15,  // Slipknot
                AlbumId = 15,   // Iowa
                GenreId = 5,    // Metal
                Length = 309
            },

            // Rap
            new Song
            {
                Id = 16,
                Name = "Alright",
                ArtistId = 16,  // Kendrick Lamar
                AlbumId = 16,   // To Pimp a Butterfly
                GenreId = 6,    // Rap
                Length = 217
            },
            new Song
            {
                Id = 17,
                Name = "In My Feelings",
                ArtistId = 17,  // Drake
                AlbumId = 17,   // Scorpion
                GenreId = 6,    // Rap
                Length = 254
            },
            new Song
            {
                Id = 18,
                Name = "No Role Modelz",
                ArtistId = 18,  // J. Cole
                AlbumId = 18,   // 2014 Forest Hills Drive
                GenreId = 6,    // Rap
                Length = 261
            },

            // Hip Hop
            new Song
            {
                Id = 19,
                Name = "99 Problems",
                ArtistId = 19,  // Jay-Z
                AlbumId = 19,   // The Blueprint
                GenreId = 7,    // Hip Hop
                Length = 220
            },
            new Song
            {
                Id = 20,
                Name = "Super Bass",
                ArtistId = 20,  // Nicki Minaj
                AlbumId = 20,   // Queen
                GenreId = 7,    // Hip Hop
                Length = 237
            },
            new Song
            {
                Id = 21,
                Name = "Bodak Yellow",
                ArtistId = 21,  // Cardi B
                AlbumId = 21,   // Invasion of Privacy
                GenreId = 7,    // Hip Hop
                Length = 259
            },

            // R&B
            new Song
            {
                Id = 22,
                Name = "Formation",
                ArtistId = 22,  // Beyoncé
                AlbumId = 22,   // Lemonade
                GenreId = 8,    // R&B
                Length = 232
            },
            new Song
            {
                Id = 23,
                Name = "Blinding Lights",
                ArtistId = 23,  // The Weeknd
                AlbumId = 23,   // After Hours
                GenreId = 8,    // R&B
                Length = 200
            },
            new Song
            {
                Id = 24,
                Name = "Nikes",
                ArtistId = 24,  // Frank Ocean
                AlbumId = 24,   // Blonde
                GenreId = 8,    // R&B
                Length = 223
            },

            // Alternative
            new Song
            {
                Id = 25,
                Name = "Karma Police",
                ArtistId = 25,  // Radiohead
                AlbumId = 25,   // OK Computer
                GenreId = 9,    // Alternative
                Length = 258
            },
            new Song
            {
                Id = 26,
                Name = "Mr. Brightside",
                ArtistId = 26,  // The Killers
                AlbumId = 26,   // Hot Fuss
                GenreId = 9,    // Alternative
                Length = 221
            },
            new Song
            {
                Id = 27,
                Name = "The Suburbs",
                ArtistId = 27,  // Arcade Fire
                AlbumId = 27,   // The Suburbs
                GenreId = 9,    // Alternative
                Length = 229
            },

            // Punk
            new Song
            {
                Id = 28,
                Name = "Blitzkrieg Bop",
                ArtistId = 28,  // The Ramones
                AlbumId = 28,   // Ramones
                GenreId = 10,   // Punk
                Length = 143
            },
            new Song
            {
                Id = 29,
                Name = "Basket Case",
                ArtistId = 29,  // Green Day
                AlbumId = 29,   // Dookie
                GenreId = 10,   // Punk
                Length = 195
            },
            new Song
            {
                Id = 30,
                Name = "London Calling",
                ArtistId = 30,  // The Clash
                AlbumId = 30,   // London Calling
                GenreId = 10,   // Punk
                Length = 210
            },

            // Emo
            new Song
            {
                Id = 31,
                Name = "Welcome to the Black Parade",
                ArtistId = 31,  // My Chemical Romance
                AlbumId = 31,   // The Black Parade
                GenreId = 11,   // Emo
                Length = 278
            },
            new Song
            {
                Id = 32,
                Name = "The Boy Who Blocked His Own Shot",
                ArtistId = 32,  // Brand New
                AlbumId = 32,   // Deja Entendu
                GenreId = 11,   // Emo
                Length = 222
            },
            new Song
            {
                Id = 33,
                Name = "Sugar, We're Goin Down",
                ArtistId = 33,  // Fall Out Boy
                AlbumId = 33,   // From Under the Cork Tree
                GenreId = 11,   // Emo
                Length = 210
            },

            // Shoegaze
            new Song
            {
                Id = 34,
                Name = "Only Shallow",
                ArtistId = 34,  // My Bloody Valentine
                AlbumId = 34,   // Loveless
                GenreId = 12,   // Shoegaze
                Length = 230
            },
            new Song
            {
                Id = 35,
                Name = "Alison",
                ArtistId = 35,  // Slowdive
                AlbumId = 35,   // Souvlaki
                GenreId = 12,   // Shoegaze
                Length = 216
            },
            new Song
            {
                Id = 36,
                Name = "Vapour Trail",
                ArtistId = 36,  // Ride
                AlbumId = 36,   // Nowhere
                GenreId = 12,   // Shoegaze
                Length = 263
            },

            // Math Rock
            new Song
            {
                Id = 37,
                Name = "Never Meant",
                ArtistId = 37,  // American Football
                AlbumId = 37,   // American Football
                GenreId = 13,   // Math Rock
                Length = 213
            },
            new Song
            {
                Id = 38,
                Name = "Goodbye",
                ArtistId = 38,  // Toe
                AlbumId = 38,   // For Long Tomorrow
                GenreId = 13,   // Math Rock
                Length = 220
            },
            new Song
            {
                Id = 39,
                Name = "Catastrophe",
                ArtistId = 39,  // TTNG
                AlbumId = 39,   // Animals
                GenreId = 13,   // Math Rock
                Length = 192
            },

            // Prog Rock
            new Song
            {
                Id = 40,
                Name = "Time",
                ArtistId = 40,  // Pink Floyd
                AlbumId = 40,   // The Dark Side of the Moon
                GenreId = 14,   // Prog Rock
                Length = 414
            },
            new Song
            {
                Id = 41,
                Name = "Roundabout",
                ArtistId = 41,  // Yes
                AlbumId = 41,   // Close to the Edge
                GenreId = 14,   // Prog Rock
                Length = 408
            },
            new Song
            {
                Id = 42,
                Name = "21st Century Schizoid Man",
                ArtistId = 42,  // King Crimson
                AlbumId = 42,   // In the Court of the Crimson King
                GenreId = 14,   // Prog Rock
                Length = 420
            },

            // Classical
            new Song
            {
                Id = 43,
                Name = "Symphony No. 9 in D minor, Op. 125",
                ArtistId = 43,  // Ludwig van Beethoven
                AlbumId = 43,   // Symphony No. 9
                GenreId = 15,   // Classical
                Length = 4800
            },
            new Song
            {
                Id = 44,
                Name = "The Magic Flute, K. 620",
                ArtistId = 44,  // Wolfgang Amadeus Mozart
                AlbumId = 44,   // The Magic Flute
                GenreId = 15,   // Classical
                Length = 3000
            },
            new Song
            {
                Id = 45,
                Name = "Prelude and Fugue in C major, BWV 846",
                ArtistId = 45,  // Johann Sebastian Bach
                AlbumId = 45,   // The Well-Tempered Clavier
                GenreId = 15,   // Classical
                Length = 230
            }
        };
    }
}