using System;
using System.Collections.Generic;
using System.Threading;

namespace Greentube
{
    /// <summary>
    /// This class simulates a remote API with one method and some network delay
    /// </summary>
    public sealed class FakeGamesApi
    {
        /// <summary>
        /// Gets the most recent list of games. The list of games will change at most once a day.
        /// </summary>
        public List<Game> GetGames()
        {
            // Simulate the kind of delay you'd have when calling a real API via the network.
            // Hint: The response time from the API is intentionally unreliable, so your code  
            // will probably want to compensate for this... 
          //  RandomDelay();

            // Return the (already deserialised) result
            return _games;
        }

        /// <summary>
        /// Delays for between 1500 and 7000 miliseconds (randomly)
        /// </summary>
        private static void RandomDelay()
        {
            Random rnd = new Random();
            int millisecondsToWait = rnd.Next(1500, 7000);
            Thread.Sleep(millisecondsToWait);
        }

        private readonly List<Game> _games = new List<Game>
        {
            new Game {
              Id = 1,
              Name = "Schnapsen"
            },
            new Game {
              Id = 2,
              Name = "Bauernschnapsen"
            },
            new Game {
              Id = 3,
              Name = "Backgammon"
            },
            new Game {
              Id = 4,
              Name = "4 to win"
            },
            new Game {
              Id = 7,
              Name = "Boule"
            },
            new Game {
              Id = 8,
              Name = "Crazy Eights"
            },
            new Game {
              Id = 9,
              Name = "Penalty King"
            },
            new Game {
              Id = 14,
              Name = "Ulti"
            },
            new Game {
              Id = 15,
              Name = "Zuminga"
            },
            new Game {
              Id = 16,
              Name = "Tarock 20"
            },
            new Game {
              Id = 17,
              Name = "Reversello"
            },
            new Game {
              Id = 18,
              Name = "Spider Solitaire"
            },
            new Game {
              Id = 19,
              Name = "31"
            },
            new Game {
              Id = 20,
              Name = "Spin7"
            },
            new Game {
              Id = 24,
              Name = "Chinchón"
            },
            new Game {
              Id = 26,
              Name = "Skat"
            },
            new Game {
              Id = 27,
              Name = "8-Ball Pool"
            },
            new Game {
              Id = 28,
              Name = "Ace Solitaire"
            },
            new Game {
              Id = 29,
              Name = "Sheepshead"
            },
            new Game {
              Id = 30,
              Name = "Rummy"
            },
            new Game {
              Id = 31,
              Name = "Canasta"
            },
            new Game {
              Id = 32,
              Name = "Chicago"
            },
            new Game {
              Id = 33,
              Name = "Mus"
            },
            new Game {
              Id = 34,
              Name = "Jolly"
            },
            new Game {
              Id = 35,
              Name = "Dominoes"
            },
            new Game {
              Id = 36,
              Name = "Marias"
            },
            new Game {
              Id = 37,
              Name = "Sergeant Major"
            },
            new Game {
              Id = 39,
              Name = "Zsírozás"
            },
            new Game {
              Id = 40,
              Name = "Mahjong"
            },
            new Game {
              Id = 41,
              Name = "Blackjack Duel"
            },
            new Game {
              Id = 42,
              Name = "Mowing Madness"
            },
            new Game {
              Id = 43,
              Name = "Solitaire Poker"
            },
            new Game {
              Id = 44,
              Name = "Maxi"
            },
            new Game {
              Id = 45,
              Name = "Rummyclub"
            },
            new Game {
              Id = 47,
              Name = "Belote"
            },
            new Game {
              Id = 48,
              Name = "Spite and Malice"
            },
            new Game {
              Id = 49,
              Name = "Bingo"
            },
            new Game {
              Id = 52,
              Name = "Bridge"
            },
            new Game {
              Id = 53,
              Name = "Doppelkopf"
            },
            new Game {
              Id = 55,
              Name = "Hongkong Mahjong"
            },
            new Game {
              Id = 57,
              Name = "Black Jack"
            },
            new Game {
              Id = 58,
              Name = "Hearts"
            },
            new Game {
              Id = 59,
              Name = "Baccarat"
            },
            new Game {
              Id = 61,
              Name = "Chess"
            },
            new Game {
              Id = 63,
              Name = "Brisca"
            },
            new Game {
              Id = 65,
              Name = "Pachisi"
            },
            new Game {
              Id = 66,
              Name = "Tarock"
            },
            new Game {
              Id = 68,
              Name = "Sic Bo"
            },
            new Game {
              Id = 69,
              Name = "Yatzy"
            },
            new Game {
              Id = 71,
              Name = "9-Ball Pool"
            },
            new Game {
              Id = 72,
              Name = "BloXX Duel"
            },
            new Game {
              Id = 74,
              Name = "66"
            },
            new Game {
              Id = 75,
              Name = "Jass"
            },
            new Game {
              Id = 76,
              Name = "Gin Rummy"
            },
            new Game {
              Id = 77,
              Name = "Solitaire"
            },
            new Game {
              Id = 79,
              Name = "Pyramids"
            },
            new Game {
              Id = 80,
              Name = "Sudoku"
            },
            new Game {
              Id = 81,
              Name = "Sugar!"
            },
            new Game {
              Id = 82,
              Name = "Snooker"
            },
            new Game {
              Id = 83,
              Name = "Explosive"
            },
            new Game {
              Id = 84,
              Name = "Triball"
            },
            new Game {
              Id = 85,
              Name = "Sudoku Bloxx"
            },
            new Game {
              Id = 86,
              Name = "Persian Treasures"
            },
            new Game {
              Id = 88,
              Name = "Scopa"
            },
            new Game {
              Id = 91,
              Name = "French Tarot"
            },
            new Game {
              Id = 95,
              Name = "Jewel Magic"
            },
            new Game {
              Id = 96,
              Name = "Darts"
            },
            new Game {
              Id = 97,
              Name = "Fruits & Sevens"
            },
            new Game {
              Id = 98,
              Name = "Bugs & Bees"
            },
            new Game {
              Id = 99,
              Name = "Mermaid’s Pearl"
            },
            new Game {
              Id = 100,
              Name = "Magic Princess"
            },
            new Game {
              Id = 101,
              Name = "Ramses II"
            },
            new Game {
              Id = 102,
              Name = "The Alchemist"
            },
            new Game {
              Id = 103,
              Name = "Quest for Gold"
            },
            new Game {
              Id = 104,
              Name = "King’s Treasure"
            },
            new Game {
              Id = 105,
              Name = "Golden Sevens"
            },
            new Game {
              Id = 106,
              Name = "Caribbean Holidays"
            },
            new Game {
              Id = 108,
              Name = "Dolphin’s Pearl™ Deluxe"
            },
            new Game {
              Id = 109,
              Name = "Lucky Lady’s Charm™ Deluxe"
            },
            new Game {
              Id = 110,
              Name = "Book of Ra™ Deluxe"
            },
            new Game {
              Id = 111,
              Name = "Columbus™ deluxe"
            },
            new Game {
              Id = 112,
              Name = "Xtra Hot™"
            },
            new Game {
              Id = 114,
              Name = "Jacks or Better"
            },
            new Game {
              Id = 115,
              Name = "Deuces Wild"
            },
            new Game {
              Id = 116,
              Name = "Joker Wild"
            },
            new Game {
              Id = 122,
              Name = "Préférence"
            },
            new Game {
              Id = 123,
              Name = "Sizzling Hot™ Deluxe"
            },
            new Game {
              Id = 126,
              Name = "Beetle Mania™ deluxe"
            },
            new Game {
              Id = 144,
              Name = "Just Jewels™  Deluxe"
            },
            new Game {
              Id = 149,
              Name = "Lord of the Ocean™"
            },
            new Game {
              Id = 157,
              Name = "Power Stars™"
            },
            new Game {
              Id = 158,
              Name = "Katana™"
            },
            new Game {
              Id = 159,
              Name = "Darling of Fortune Scratch "
            },
            new Game {
              Id = 165,
              Name = "Multiball Roulette"
            },
            new Game {
              Id = 174,
              Name = "Book of Ra™"
            },
            new Game {
              Id = 179,
              Name = "Plenty on Twenty"
            },
            new Game {
              Id = 182,
              Name = "Big Catch™"
            },
            new Game {
              Id = 183,
              Name = "Bullion Bars™"
            },
            new Game {
              Id = 184,
              Name = "Golden 7™"
            },
            new Game {
              Id = 185,
              Name = "Party Games Slotto™"
            },
            new Game {
              Id = 186,
              Name = "Win Wizard™"
            },
            new Game {
              Id = 190,
              Name = "Sharky™"
            },
            new Game {
              Id = 193,
              Name = "President"
            },
            new Game {
              Id = 196,
              Name = "European Roulette"
            },
            new Game {
              Id = 198,
              Name = "Yatzy Live"
            },
            new Game {
              Id = 207,
              Name = "Roaring Forties™"
            },
            new Game {
              Id = 215,
              Name = "Rex™"
            },
            new Game {
              Id = 228,
              Name = "Buraco"
            },
            new Game {
              Id = 231,
              Name = "Rainbow King™"
            },
            new Game {
              Id = 239,
              Name = "Dolphin’s Pearl™ "
            },
            new Game {
              Id = 242,
              Name = "Ultra Hot™deluxe"
            },
            new Game {
              Id = 243,
              Name = "Jewel Action"
            },
            new Game {
              Id = 245,
              Name = "Pesten"
            },
            new Game {
              Id = 250,
              Name = "Prophet"
            },
            new Game {
              Id = 251,
              Name = "Spinning Stars™"
            },
            new Game {
              Id = 260,
              Name = "Indian Spirit™"
            },
            new Game {
              Id = 265,
              Name = "Marilyn’s Diamonds™"
            },
            new Game {
              Id = 266,
              Name = "Vegas Roulette™"
            },
            new Game {
              Id = 268,
              Name = "Globe Roulette"
            },
            new Game {
              Id = 269,
              Name = "Fruits’n Royals™"
            },
            new Game {
              Id = 274,
              Name = "Secret Elixir™"
            },
            new Game {
              Id = 281,
              Name = "Fairy Queen™"
            },
            new Game {
              Id = 287,
              Name = "Costa del Cash™ "
            },
            new Game {
              Id = 295,
              Name = "Aztec Power™ "
            },
            new Game {
              Id = 302,
              Name = "African Simba™"
            },
            new Game {
              Id = 306,
              Name = "Hot Chance"
            },
            new Game {
              Id = 309,
              Name = "Fruit Sensation"
            },
            new Game {
              Id = 314,
              Name = "Mystic Secrets™"
            },
            new Game {
              Id = 321,
              Name = "Hollywood Star™"
            },
            new Game {
              Id = 325,
              Name = "Firestarter™"
            },
            new Game {
              Id = 332,
              Name = "Gorilla™"
            },
            new Game {
              Id = 335,
              Name = "Lucky Rose"
            },
            new Game {
              Id = 341,
              Name = "Golden Ark"
            },
            new Game {
              Id = 347,
              Name = "Sea Sirens"
            },
            new Game {
              Id = 352,
              Name = "Royal Dynasty"
            },
            new Game {
              Id = 353,
              Name = "Captain Venture"
            },
            new Game {
              Id = 354,
              Name = "Garden of Riches"
            },
            new Game {
              Id = 358,
              Name = "Happy Farm Scratch "
            },
            new Game {
              Id = 364,
              Name = "Two Mayans™"
            },
            new Game {
              Id = 371,
              Name = "CatScratchFever™"
            },
            new Game {
              Id = 377,
              Name = "Knights Quest™"
            },
            new Game {
              Id = 380,
              Name = "Reel King"
            },
            new Game {
              Id = 381,
              Name = "Marilyn Red Carpet™"
            },
            new Game {
              Id = 389,
              Name = "Dazzling Diamonds"
            },
            new Game {
              Id = 400,
              Name = "Mayan Moons™"
            },
            new Game {
              Id = 406,
              Name = "Pharaoh’s Ring™"
            },
            new Game {
              Id = 412,
              Name = "Flame Dancer™"
            },
            new Game {
              Id = 416,
              Name = "Jackpot Crown™"
            },
            new Game {
              Id = 420,
              Name = "Pharaoh’s Tomb™"
            },
            new Game {
              Id = 426,
              Name = "Chicago™"
            },
            new Game {
              Id = 433,
              Name = "Diamond 7 "
            },
            new Game {
              Id = 438,
              Name = "Golden Cobras™ Deluxe"
            },
            new Game {
              Id = 445,
              Name = "Rumpel Wildspins™"
            },
            new Game {
              Id = 452,
              Name = "Orca™"
            },
            new Game {
              Id = 458,
              Name = "Queen of Hearts Deluxe™"
            },
            new Game {
              Id = 465,
              Name = "Cindereela™"
            },
            new Game {
              Id = 468,
              Name = "Marilyn’s Diamonds™ Deluxe"
            },
            new Game {
              Id = 475,
              Name = "The Royals"
            },
            new Game {
              Id = 488,
              Name = "Fruit Farm™"
            },
            new Game {
              Id = 518,
              Name = "Battlefleet"
            },
            new Game {
              Id = 522,
              Name = "American Poker II"
            },
            new Game {
              Id = 523,
              Name = "Marilyn’s Poker II™"
            },
            new Game {
              Id = 528,
              Name = "Tarneeb"
            },
            new Game {
              Id = 536,
              Name = "Win Wizards™"
            },
            new Game {
              Id = 543,
              Name = "Bear Tracks™"
            },
            new Game {
              Id = 556,
              Name = "Cops´n´Robbers"
            },
            new Game {
              Id = 557,
              Name = "HappyFruits"
            },
            new Game {
              Id = 558,
              Name = "Wizard of Odds"
            },
            new Game {
              Id = 559,
              Name = "Rumble In The Jungle"
            },
            new Game {
              Id = 560,
              Name = "Spinderella"
            },
            new Game {
              Id = 562,
              Name = "Rainbow Reels"
            },
            new Game {
              Id = 564,
              Name = "Clockwork Oranges"
            },
            new Game {
              Id = 565,
              Name = "Gemstone Jackpot"
            },
            new Game {
              Id = 585,
              Name = "Hold Your Horses"
            },
            new Game {
              Id = 603,
              Name = "Flamenco Roses™"
            },
            new Game {
              Id = 609,
              Name = "Mega Joker™"
            },
            new Game {
              Id = 630,
              Name = "Hot Cubes™"
            },
            new Game {
              Id = 640,
              Name = "Always Hot Cubes™"
            },
            new Game {
              Id = 654,
              Name = "Hoffmania™"
            },
            new Game {
              Id = 674,
              Name = "ShowGirls™"
            },
            new Game {
              Id = 690,
              Name = "Sizzling Hot Quattro™"
            },
            new Game {
              Id = 809,
              Name = "Jolly Fruits™"
            },
            new Game {
              Id = 851,
              Name = "Texas Hold’em"
            },
            new Game {
              Id = 852,
              Name = "Omaha"
            },
            new Game {
              Id = 855,
              Name = "5 Card Draw"
            },
            new Game {
              Id = 899,
              Name = "Anubix"
            },
            new Game {
              Id = 902,
              Name = "Bloody Love"
            },
            new Game {
              Id = 914,
              Name = "4 Reel Kings™"
            },
            new Game {
              Id = 916,
              Name = "Nineballs "
            },
            new Game {
              Id = 917,
              Name = "Silverball"
            },
            new Game {
              Id = 918,
              Name = "Pharao´s Bingo"
            },
            new Game {
              Id = 931,
              Name = "Hoffmeister™"
            },
            new Game {
              Id = 934,
              Name = "Baloot"
            },
            new Game {
              Id = 938,
              Name = "Super Dice™"
            },
            new Game {
              Id = 940,
              Name = "Fruitilicious™"
            },
            new Game {
              Id = 942,
              Name = "Mystery Star™"
            },
            new Game {
              Id = 986,
              Name = "Mystery Roulette™ x38"
            },
            new Game {
              Id = 1027,
              Name = "Random Runner™15"
            },
            new Game {
              Id = 1076,
              Name = "Armadillo Artie™"
            },
            new Game {
              Id = 1156,
              Name = "Royal Crown Roulette European"
            },
            new Game {
              Id = 1251,
              Name = "Sizzling6™"
            },
            new Game {
              Id = 1312,
              Name = "Slotcar Speed"
            },
            new Game {
              Id = 90,
              Name = "Game alarm"
            },
            new Game {
              Id = 131,
              Name = "Book of Ra™ Deluxe"
            },
            new Game {
              Id = 356,
              Name = "Amazing Stars "
            },
            new Game {
              Id = 442,
              Name = "Sizzling Gems™"
            },
            new Game {
              Id = 561,
              Name = "Cleopatra"
            },
            new Game {
              Id = 592,
              Name = "Wild Rescue™"
            },
            new Game {
              Id = 634,
              Name = "Always Hot™ Deluxe"
            },
            new Game {
              Id = 650,
              Name = "Sinderella"
            },
            new Game {
              Id = 713,
              Name = "Red Lady"
            },
            new Game {
              Id = 740,
              Name = "Xtra Hot™"
            },
            new Game {
              Id = 861,
              Name = "Ninja’s Path™"
            },
            new Game {
              Id = 882,
              Name = "Dynamite Bingo"
            },
            new Game {
              Id = 883,
              Name = "Crazy Cactus"
            },
            new Game {
              Id = 884,
              Name = "Express Bonus"
            },
            new Game {
              Id = 885,
              Name = "Wizard Bingo"
            },
            new Game {
              Id = 886,
              Name = "Beach Party"
            },
            new Game {
              Id = 944,
              Name = "Wonder World™"
            },
            new Game {
              Id = 968,
              Name = "Pure Jewels™"
            },
            new Game {
              Id = 975,
              Name = "King of Cards™"
            },
            new Game {
              Id = 1025,
              Name = "Wild Thing"
            },
            new Game {
              Id = 1029,
              Name = "Jokers Casino™"
            },
            new Game {
              Id = 1031,
              Name = "Multi Dice™"
            },
            new Game {
              Id = 1033,
              Name = "Grand Slam™ Casino"
            },
            new Game {
              Id = 1041,
              Name = "Inferno™"
            },
            new Game {
              Id = 1102,
              Name = "Boto Bingo"
            },
            new Game {
              Id = 1126,
              Name = "Two Sevens"
            },
            new Game {
              Id = 1168,
              Name = "Power Joker™"
            },
            new Game {
              Id = 1204,
              Name = "Mighty Trident"
            },
            new Game {
              Id = 1205,
              Name = "Bar 7’s"
            },
            new Game {
              Id = 1206,
              Name = "Diamonds of Fortune"
            },
            new Game {
              Id = 1213,
              Name = "Volcanic Cash™"
            },
            new Game {
              Id = 1219,
              Name = "Fruit Drops"
            },
            new Game {
              Id = 1411,
              Name = "Magic27"
            },
            new Game {
              Id = 1418,
              Name = "Magic 81 Lines™"
            },
            new Game {
              Id = 1425,
              Name = "Burning Hot™ 7‘s"
            },
            new Game {
              Id = 1439,
              Name = "Orca™"
            },
            new Game {
              Id = 1619,
              Name = "Slots – Pharaoh’s Way"
            },
            new Game {
              Id = 1631,
              Name = "Royal Crown Blackjack"
            },
            new Game {
              Id = 1635,
              Name = "Royal Crown 3 Card Brag"
            },
            new Game {
              Id = 3550,
              Name = "Bet on Dogs™"
            },
            new Game {
              Id = 3732,
              Name = "Dragons Mystery "
            },
            new Game {
              Id = 3733,
              Name = "Joker Fortune "
            },
            new Game {
              Id = 3734,
              Name = "King Bam Bam "
            },
            new Game {
              Id = 3735,
              Name = "Robyn"
            },
            new Game {
              Id = 3736,
              Name = "Orion"
            },
            new Game {
              Id = 3737,
              Name = "Genesis Game 3"
            },
            new Game {
              Id = 3738,
              Name = "Genesis Game 4"
            },
            new Game {
              Id = 3739,
              Name = "Genesis Game 5"
            },
            new Game {
              Id = 1159,
              Name = "5 Line Jokers™"
            },
            new Game {
              Id = 1217,
              Name = "Dragon’s Wild Fire"
            },
            new Game {
              Id = 428,
              Name = "Chicago™"
            },
            new Game {
              Id = 4109,
              Name = "Random Runner TWIN Player "
            },
            new Game {
              Id = 4110,
              Name = "Twin Joker "
            },
            new Game {
              Id = 4111,
              Name = "Fruit Smasher"
            },
            new Game {
              Id = 4112,
              Name = "Extreme "
            },
            new Game {
              Id = 4113,
              Name = "Las Vegas Fever"
            },
            new Game {
              Id = 4117,
              Name = "Random2Wins"
            },
            new Game {
              Id = 4118,
              Name = "Game 2000"
            }
 


        };
    }
}
