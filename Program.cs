using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Threading.Tasks;

namespace DungeonMaster
{

    class Program1
    {
       static List<Character> characters = new List<Character>();
        static void WriteToCsv(List<Character> characters)
        {
            using (var writer = new StreamWriter("Characters.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(characters);
            }
        }
        static  List<Character> ReadFromCsv()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HeaderValidated = null
            };
            using (var reader = new StreamReader("Characters.csv"))
            using (var csv = new CsvReader(reader, config))
            {
              var  characters = csv.GetRecords<Character>().ToList();
                return characters;
            }
        }

        

        static void Main(string[] args)

        {
            string flair = "***********************************";
            characters = ReadFromCsv();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("            Welcome To             ");
            Console.WriteLine("            Dungeon Master         ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            string userSelection;

            do
            {
                Console.WriteLine("1. Create Character");
                Console.WriteLine("2. Review Characters");
                Console.WriteLine("3. Session Calendar");
                Console.WriteLine("9. Exit");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                      var task = CreateCharacter();
                        task.Wait();
                        break;

                    case "2":
                        ReviewCharacter();
                        break;

                    case "3":
                        SessionTime();
                        break;
                }
            } while (userSelection != "9");

            Console.WriteLine("Until fate sees your return...");
            Console.Read();
        }
        private static async Task CreateCharacter()
        {
            string flair = "***********************************";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         What is your name?           ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            string playerName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   What is your character name?   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            string characterName = Console.ReadLine();


            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   What is your character level?   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            bool characterLevelStatus = false;
            string characterLevel;

            do
            {
                characterLevel = Console.ReadLine();
                switch (characterLevel)
                {
                    case "1":
                        characterLevel = "1";
                        characterLevelStatus = true;
                        break;
                    case "one":
                        characterLevel = "1";
                        characterLevelStatus = true;
                        break;
                    case "2":
                        characterLevel = "2";
                        characterLevelStatus = true;
                        break;
                    case "two":
                        characterLevel = "2";
                        characterLevelStatus = true;
                        break;
                    case "3":
                        characterLevel = "3";
                        characterLevelStatus = true;
                        break;
                    case "three":
                        characterLevel = "3";
                        characterLevelStatus = true;
                        break;
                    case "4":
                        characterLevel = "4";
                        characterLevelStatus = true;
                        break;
                    case "four":
                        characterLevel = "4";
                        characterLevelStatus = true;
                        break;
                    case "5":
                        characterLevel = "5";
                        characterLevelStatus = true;
                        break;
                    case "five":
                        characterLevel = "5";
                        characterLevelStatus = true;
                        break;
                    case "6":
                        characterLevel = "6";
                        characterLevelStatus = true;
                        break;
                    case "six":
                        characterLevel = "6";
                        characterLevelStatus = true;
                        break;
                    case "7":
                        characterLevel = "7";
                        characterLevelStatus = true;
                        break;
                    case "seven":
                        characterLevel = "7";
                        characterLevelStatus = true;
                        break;
                    case "8":
                        characterLevel = "8";
                        characterLevelStatus = true;
                        break;
                    case "eight":
                        characterLevel = "8";
                        characterLevelStatus = true;
                        break;
                    case "9":
                        characterLevel = "9";
                        characterLevelStatus = true;
                        break;
                    case "nine":
                        characterLevel = "9";
                        characterLevelStatus = true;
                        break;
                    case "10":
                        characterLevel = "10";
                        characterLevelStatus = true;
                        break;
                    case "ten":
                        characterLevel = "10";
                        characterLevelStatus = true;
                        break;
                    case "11":
                        characterLevel = "11";
                        characterLevelStatus = true;
                        break;
                    case "eleven":
                        characterLevel = "11";
                        characterLevelStatus = true;
                        break;
                    case "12":
                        characterLevel = "12";
                        characterLevelStatus = true;
                        break;
                    case "twelve":
                        characterLevel = "12";
                        characterLevelStatus = true;
                        break;
                    case "13":
                        characterLevel = "13";
                        characterLevelStatus = true;
                        break;
                    case "thirteen":
                        characterLevel = "13";
                        characterLevelStatus = true;
                        break;
                    case "14":
                        characterLevel = "14";
                        characterLevelStatus = true;
                        break;
                    case "fourteen":
                        characterLevel = "14";
                        characterLevelStatus = true;
                        break;
                    case "15":
                        characterLevel = "15";
                        characterLevelStatus = true;
                        break;
                    case "fifteen":
                        characterLevel = "15";
                        characterLevelStatus = true;
                        break;
                    case "16":
                        characterLevel = "16";
                        characterLevelStatus = true;
                        break;
                    case "sixteen":
                        characterLevel = "16";
                        characterLevelStatus = true;
                        break;
                    case "17":
                        characterLevel = "17";
                        characterLevelStatus = true;
                        break;
                    case "seventeen":
                        characterLevel = "17";
                        characterLevelStatus = true;
                        break;
                    case "18":
                        characterLevel = "18";
                        characterLevelStatus = true;
                        break;
                    case "eighteen":
                        characterLevel = "18";
                        characterLevelStatus = true;
                        break;
                    case "19":
                        characterLevel = "19";
                        characterLevelStatus = true;
                        break;
                    case "nineteen":
                        characterLevel = "19";
                        characterLevelStatus = true;
                        break;
                    case "20":
                        characterLevel = "20";
                        characterLevelStatus = true;
                        break;
                    case "twenty":
                        characterLevel = "20";
                        characterLevelStatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please make a selection between 1-20.");
                        characterLevelStatus = false;
                        break;
                }

            } while (!characterLevelStatus);




            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      What is your alignment?      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            var client = DnD5eAPIClient.Client();
            DnDResult<DnD5EAlignments> alignments = new DnDResult<DnD5EAlignments>();
            try
            {
                alignments = await client.GetAlignmentsAsync();
            }
            catch (Exception e) { Console.WriteLine("API is currently down"); } //ensures API is active. Maybe write this to file.

            for (int i = 0; i < alignments.Results.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {alignments.Results[i].Name}");
            }

            bool characterAlignmentStatus = false;
            string characterAlignment;
            
            do
            {
                characterAlignment = Console.ReadLine();

                switch (characterAlignment)
                {
                    case "1":
                        characterAlignment = "Chaotic Evil";
                        characterAlignmentStatus = true;
                        break;
                    case "2":
                        characterAlignment = "Chaotic Good";
                        characterAlignmentStatus = true;
                        break;
                    case "3":
                        characterAlignment = "Chaotic Neutral";
                        characterAlignmentStatus = true;
                        break;
                    case "4":
                        characterAlignment = "Lawful Evil";
                        characterAlignmentStatus = true;
                        break;
                    case "5":
                        characterAlignment = "Lawful Good";
                        characterAlignmentStatus = true;
                        break;
                    case "6":
                        characterAlignment = "Lawful Neutral";
                        characterAlignmentStatus = true;
                        break;
                    case "7":
                        characterAlignment = "Neutral";
                        characterAlignmentStatus = true;
                        break;
                    case "8":
                        characterAlignment = "Neutral Evil";
                        characterAlignmentStatus = true;
                        break;
                    case "9":
                        characterAlignment = "Neutral Good";
                        characterAlignmentStatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        characterAlignmentStatus = false;
                        break;
                }
            } while (!characterAlignmentStatus);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     What is your background?      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            //Background only has one option, Acolyte, on the API? Remove, or keep hard coded?

            Console.WriteLine("1: Acolyte");
            Console.WriteLine("2: Anthropologist");
            Console.WriteLine("3: Archaeologist");
            Console.WriteLine("4: Athlete");
            Console.WriteLine("5: Azorius Functionary");
            Console.WriteLine("6: Boros Legionnaire");
            Console.WriteLine("7: Celebrity Adventurer's Scoin");
            Console.WriteLine("8: Charlata");
            Console.WriteLine("9: City Watch");
            Console.WriteLine("10: Clan Crafter");
            Console.WriteLine("11: Cloistered Scholar");
            Console.WriteLine("12: Courtier");
            Console.WriteLine("13: Criminal");
            Console.WriteLine("14: Dimir Operative");
            Console.WriteLine("15: Entertainer");
            Console.WriteLine("16: Faceless");
            Console.WriteLine("17: Faction Agent");
            Console.WriteLine("18: Failed Merchant");
            Console.WriteLine("19: Far Traveler");
            Console.WriteLine("20: Feylost");
            Console.WriteLine("21: Fisher");
            Console.WriteLine("22: Folk Hero");
            Console.WriteLine("23: Gambler");
            Console.WriteLine("24: Gladiator");
            Console.WriteLine("25: Golgari Agent");
            Console.WriteLine("26: Grinner");
            Console.WriteLine("27: Gruul Anarch");
            Console.WriteLine("28: Guild Artisan");
            Console.WriteLine("29: Guild Merchant");
            Console.WriteLine("30: Haunted One");
            Console.WriteLine("31: Hermit");
            Console.WriteLine("32: House Agent");
            Console.WriteLine("33: Inheritor");
            Console.WriteLine("34: Investigator");
            Console.WriteLine("35: Izzet Engineer");
            Console.WriteLine("36: Knight");
            Console.WriteLine("37: Kinght of the Order");
            Console.WriteLine("38: Lorehold Student");
            Console.WriteLine("39: Marine");
            Console.WriteLine("40: Mercenary Veteran");
            Console.WriteLine("41: Noble");
            Console.WriteLine("42: Orzhov Representative");
            Console.WriteLine("43: Outlander");
            Console.WriteLine("44: Pirate");
            Console.WriteLine("45: Plaintiff");
            Console.WriteLine("46: Prismari Student");
            Console.WriteLine("47: Quandrix Student");
            Console.WriteLine("48: Rakdos Cultist");
            Console.WriteLine("49: Rival Intern");
            Console.WriteLine("50: Sage");
            Console.WriteLine("51: Sailor");
            Console.WriteLine("52: Selesnya Initiate");
            Console.WriteLine("53: Shipwright");
            Console.WriteLine("54: Silverquill Student");
            Console.WriteLine("55: Simic Scientist");
            Console.WriteLine("56: Smuggler");
            Console.WriteLine("57: Soldier");
            Console.WriteLine("58: Spy");
            Console.WriteLine("59: Urban Bounty Hunter");
            Console.WriteLine("60: Urchin");
            Console.WriteLine("61: Uthgardt Tribe Member");
            Console.WriteLine("62: Volstrucker Agent");
            Console.WriteLine("63: Waterdhavian Noble");
            Console.WriteLine("64: Witchlight Hand");
            Console.WriteLine("65: Witherbloom Student");

            bool characterBackgroundStatus = false;
            string characterBackground;
            do
            {
                characterBackground = Console.ReadLine();
                switch (characterBackground)
                {
                    case "1":
                        characterBackground = "Acolyte";
                        characterBackgroundStatus = true;
                        break;
                    case "2":
                        characterBackground = "Anthropologist";
                        characterBackgroundStatus = true;
                        break;
                    case "3":
                        characterBackground = "Archaeologist";
                        characterBackgroundStatus = true;
                        break;
                    case "4":
                        characterBackground = "Athlete";
                        characterBackgroundStatus = true;
                        break;
                    case "5":
                        characterBackground = "Azorius Functionary";
                        characterBackgroundStatus = true;
                        break;
                    case "6":
                        characterBackground = "Boros Legionnaire";
                        characterBackgroundStatus = true;
                        break;
                    case "7":
                        characterBackground = "Celebrity Adventurer's Scoin";
                        characterBackgroundStatus = true;
                        break;
                    case "8":
                        characterBackground = "Charlata";
                        characterBackgroundStatus = true;
                        break;
                    case "9":
                        characterBackground = "City Watch";
                        characterBackgroundStatus = true;
                        break;
                    case "10":
                        characterBackground = "Clan Crafter";
                        characterBackgroundStatus = true;
                        break;
                    case "11":
                        characterBackground = "Cloistered Scholar";
                        characterBackgroundStatus = true;
                        break;
                    case "12":
                        characterBackground = "Courtier";
                        characterBackgroundStatus = true;
                        break;
                    case "13":
                        characterBackground = "Criminal";
                        characterBackgroundStatus = true;
                        break;
                    case "14":
                        characterBackground = "Dimir Operative";
                        characterBackgroundStatus = true;
                        break;
                    case "15":
                        characterBackground = "Entertainer";
                        characterBackgroundStatus = true;
                        break;
                    case "16":
                        characterBackground = "Faceless";
                        characterBackgroundStatus = true;
                        break;
                    case "17":
                        characterBackground = "Faction Agent";
                        characterBackgroundStatus = true;
                        break;
                    case "18":
                        characterBackground = "Failed Merchant";
                        characterBackgroundStatus = true;
                        break;
                    case "19":
                        characterBackground = "Far Traveler";
                        characterBackgroundStatus = true;
                        break;
                    case "20":
                        characterBackground = "Feylost";
                        characterBackgroundStatus = true;
                        break;
                    case "21":
                        characterBackground = "Fisher";
                        characterBackgroundStatus = true;
                        break;
                    case "22":
                        characterBackground = "Folk Hero";
                        characterBackgroundStatus = true;
                        break;
                    case "23":
                        characterBackground = "Gambler";
                        characterBackgroundStatus = true;
                        break;
                    case "24":
                        characterBackground = "Gladiator";
                        characterBackgroundStatus = true;
                        break;
                    case "25":
                        characterBackground = "Golgari Agent";
                        characterBackgroundStatus = true;
                        break;
                    case "26":
                        characterBackground = "Grinner";
                        characterBackgroundStatus = true;
                        break;
                    case "27":
                        characterBackground = "Gruul Anarch";
                        characterBackgroundStatus = true;
                        break;
                    case "28":
                        characterBackground = "Guild Artisan";
                        characterBackgroundStatus = true;
                        break;
                    case "29":
                        characterBackground = "Guild Merchan";
                        characterBackgroundStatus = true;
                        break;
                    case "30":
                        characterBackground = "Haunted One";
                        characterBackgroundStatus = true;
                        break;
                    case "31":
                        characterBackground = "Hermit";
                        characterBackgroundStatus = true;
                        break;
                    case "32":
                        characterBackground = "House Agent";
                        characterBackgroundStatus = true;
                        break;
                    case "33":
                        characterBackground = "Inheritor";
                        characterBackgroundStatus = true;
                        break;
                    case "34":
                        characterBackground = "Investigator";
                        characterBackgroundStatus = true;
                        break;
                    case "35":
                        characterBackground = "Izzet Engineer";
                        characterBackgroundStatus = true;
                        break;
                    case "36":
                        characterBackground = "Knight";
                        characterBackgroundStatus = true;
                        break;
                    case "37":
                        characterBackground = "Kinght of the Order";
                        characterBackgroundStatus = true;
                        break;
                    case "38":
                        characterBackground = "Lorehold Student";
                        characterBackgroundStatus = true;
                        break;
                    case "39":
                        characterBackground = "Marine";
                        characterBackgroundStatus = true;
                        break;
                    case "40":
                        characterBackground = "Mercenary Veteran";
                        characterBackgroundStatus = true;
                        break;
                    case "41":
                        characterBackground = "Noble";
                        characterBackgroundStatus = true;
                        break;
                    case "42":
                        characterBackground = "Orzhov Representative";
                        characterBackgroundStatus = true;
                        break;
                    case "43":
                        characterBackground = "Outlander";
                        characterBackgroundStatus = true;
                        break;
                    case "44":
                        characterBackground = "Pirate";
                        characterBackgroundStatus = true;
                        break;
                    case "45":
                        characterBackground = "Plantiff";
                        characterBackgroundStatus = true;
                        break;
                    case "46":
                        characterBackground = "Prismari Student";
                        characterBackgroundStatus = true;
                        break;
                    case "47":
                        characterBackground = "Quandrix Student";
                        characterBackgroundStatus = true;
                        break;
                    case "48":
                        characterBackground = "Rakdos Cultist";
                        characterBackgroundStatus = true;
                        break;
                    case "49":
                        characterBackground = "Rival Intern";
                        characterBackgroundStatus = true;
                        break;
                    case "50":
                        characterBackground = "Sage";
                        characterBackgroundStatus = true;
                        break;
                    case "51":
                        characterBackground = "Sailor";
                        characterBackgroundStatus = true;
                        break;
                    case "52":
                        characterBackground = "Selesnya Initiate";
                        characterBackgroundStatus = true;
                        break;
                    case "53":
                        characterBackground = "Shipwright";
                        characterBackgroundStatus = true;
                        break;
                    case "54":
                        characterBackground = "Silverquill Student";
                        characterBackgroundStatus = true;
                        break;
                    case "55":
                        characterBackground = "Simic Scientist";
                        characterBackgroundStatus = true;
                        break;
                    case "56":
                        characterBackground = "Smuggler";
                        characterBackgroundStatus = true;
                        break;
                    case "57":
                        characterBackground = "Soldier";
                        characterBackgroundStatus = true;
                        break;
                    case "58":
                        characterBackground = "Spy";
                        characterBackgroundStatus = true;
                        break;
                    case "59":
                        characterBackground = "Urban Bounty Hunter";
                        characterBackgroundStatus = true;
                        break;
                    case "60":
                        characterBackground = "Urchin";
                        characterBackgroundStatus = true;
                        break;
                    case "61":
                        characterBackground = "Uthgardt Tribe Member";
                        characterBackgroundStatus = true;
                        break;
                    case "62":
                        characterBackground = "Volstrucker Agent";
                        characterBackgroundStatus = true;
                        break;
                    case "63":
                        characterBackground = "Waterdhavian Noble";
                        characterBackgroundStatus = true;
                        break;
                    case "64":
                        characterBackground = "Witchlight Hand";
                        characterBackgroundStatus = true;
                        break;
                    case "65":
                        characterBackground = "Witherbloom Student";
                        characterBackgroundStatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        characterBackgroundStatus = false;
                        break;
                }
            } while (!characterBackgroundStatus);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        What is your race?         ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            
            DnDResult<DnD5ERaces> races = new DnDResult<DnD5ERaces>();
            try
            {
                races = await client.GetRacesAsync();
            }
            catch (Exception e) { Console.WriteLine("API is currently down"); } //ensures API is active. Maybe write this to file.

            for (int i = 0; i < races.Results.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {races.Results[i].Name}");
            }

            bool characterRaceStatus = false;
            string characterRace;
            do
            {
                characterRace = Console.ReadLine();
                switch (characterRace)
                {
                    case "1":
                        characterRace = "Dragonborn";
                        characterRaceStatus = true;
                        break;
                    case "2":
                        characterRace = "Dwarf";
                        characterRaceStatus = true;
                        break;
                    case "3":
                        characterRace = "Elf";
                        characterRaceStatus = true;
                        break;
                    case "4":
                        characterRace = "Gnome";
                        characterRaceStatus = true;
                        break;
                    case "5":
                        characterRace = "Half-Elf";
                        characterRaceStatus = true;
                        break;
                    case "6":
                        characterRace = "Half-Orc";
                        characterRaceStatus = true;
                        break;
                    case "7":
                        characterRace = "Halfing";
                        characterRaceStatus = true;
                        break;
                    case "8":
                        characterRace = "Human";
                        characterRaceStatus = true;
                        break;
                    case "9":
                        characterRace = "Tiefling";
                        characterRaceStatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        characterRaceStatus = false;
                        break;
                }
            } while (!characterRaceStatus);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        What is your class?        ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            //var client = DnD5eAPIClient.Client();
            DnDResult<DnD5EClass> classes = new DnDResult<DnD5EClass>();
            try {
                classes = await client.GetClassesAsync();
            } catch (Exception e) { Console.WriteLine("API is currently down"); } //ensures API is active. Maybe write this to file.
            
            for (int i = 0; i < classes.Results.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {classes.Results[i].Name}");
            }

            bool characterClassStatus = false;
            string characterClass;

            do
            {
                characterClass = Console.ReadLine();
                switch (characterClass)
                {
                    case "1":
                        characterClass = "Barbarian";
                        characterClassStatus = true;
                        break;
                    case "2":
                        characterClass = "Bard";
                        characterClassStatus = true;
                        break;
                    case "3":
                        characterClass = "Cleric";
                        characterClassStatus = true;
                        break;
                    case "4":
                        characterClass = "Druid";
                        characterClassStatus = true;
                        break;
                    case "5":
                        characterClass = "Fighter";
                        characterClassStatus = true;
                        break;
                    case "6":
                        characterClass = "Monk";
                        characterClassStatus = true;
                        break;
                    case "7":
                        characterClass = "Paladin";
                        characterClassStatus = true;
                        break;
                    case "8":
                        characterClass = "Ranger";
                        characterClassStatus = true;
                        break;
                    case "9":
                        characterClass = "Rogue";
                        characterClassStatus = true;
                        break;
                    case "10":
                        characterClass = "Sorcerer";
                        characterClassStatus = true;
                        break;
                    case "11":
                        characterClass = "Warlock";
                        characterClassStatus = true;
                        break;
                    case "12":
                        characterClass = "Wizard";
                        characterClassStatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        characterClassStatus = false;
                        break;
                }
            } while (!characterClassStatus);

            Random stat = new Random();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        Press Enter to             ");
            Console.WriteLine("        Roll for Strength          ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            while(Console.ReadKey(true).Key != ConsoleKey.Enter);
            int characterStrength = stat.Next(3, 19);
            Console.WriteLine($"{characterStrength}");
            
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        Press Enter to             ");
            Console.WriteLine("        Roll for Dexterity         ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            int characterDexterity = stat.Next(3, 19);
            Console.WriteLine($"{characterDexterity}");
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        Press Enter to             ");
            Console.WriteLine("        Roll for Constitution      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            while(Console.ReadKey(true).Key != ConsoleKey.Enter);
            int characterConstitution = stat.Next(3, 19);
            Console.WriteLine($"{characterConstitution}");
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        Press Enter to             ");
            Console.WriteLine("        Roll for Intelligence      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            int characterIntelligence = stat.Next(3, 19);
            Console.WriteLine($"{characterIntelligence}");


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        Press Enter to             ");
            Console.WriteLine("        Roll for Wisdom            ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            int characterWisdom = stat.Next(3, 19);
            Console.WriteLine($"{characterWisdom}");
            

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        Press Enter to             ");
            Console.WriteLine("        Roll for Charisma          ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            int characterCharisma = stat.Next(3, 19);
            Console.WriteLine($"{characterCharisma}");
            

            Character character = new Character(playerName, characterName, characterBackground, characterAlignment,
                characterLevel, characterRace, characterClass, characterStrength, characterDexterity, characterConstitution,
                characterIntelligence, characterWisdom, characterCharisma);
            characters.Add(character);

            WriteToCsv(characters);


            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" You have created a new character! ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void ReviewCharacter()
        {
            string flair = "***********************************";

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           Characters              ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

           characters = ReadFromCsv();
           

                    characters.ForEach(character =>
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(character.CharacterName);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Player: {character.PlayerName}");
                        Console.WriteLine($"Level: {character.CharacterLevel}");
                        Console.WriteLine($"Class: {character.CharacterClass}");
                        Console.WriteLine($"Race: {character.CharacterRace}");
                        Console.WriteLine($"Background: {character.CharacterBackground}");
                        Console.WriteLine($"Alignment: {character.CharacterAlignment}");
                        Console.WriteLine($"Strength: {character.CharacterStrength}");
                        Console.WriteLine($"Dexterity: {character.CharacterDexterity}");
                        Console.WriteLine($"Constitution: {character.CharacterConstitution}");
                        Console.WriteLine($"Intelligence: {character.CharacterIntelligence}");
                        Console.WriteLine($"Wisdom: {character.CharacterWisdom}");
                        Console.WriteLine($"Charisma: {character.CharacterCharisma}");

                        Console.WriteLine();
                        Console.WriteLine();

                    });
                    
                    
                    

        }
        static void SessionTime()
        {
            DateTime userDaysLeft;
            DateTime startDate = DateTime.Now;

            Console.WriteLine("Please enter the date and time of your next game (mm/dd/yyyy 00:01-23:59)");
            if (DateTime.TryParse(Console.ReadLine(), out userDaysLeft))
            {
                
            }
            else
            {
                Console.WriteLine("You have entered an invalid date. Please try again from the menu.");
            }
            //How do we get the error time to not display?

            TimeSpan t = userDaysLeft - startDate;
            string countDown = string.Format("{0} Days, {1} Hours, {2} Minutes until your next game!", t.Days, t.Hours, t.Minutes);

            Console.WriteLine(countDown);
        }
    }
}
    

