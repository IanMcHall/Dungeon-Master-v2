using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;




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
            characters = ReadFromCsv();
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("            Welcome To             ");
            Console.WriteLine("            Dungeon Master         ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string userSelection;

            do
            {
                Console.WriteLine("1. Create a character");
                Console.WriteLine("2. Review Characters");
                Console.WriteLine("9. Exit");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        CreateCharacter();
                        break;

                    case "2":
                        ReviewCharacter();
                        break;
                }
            } while (userSelection != "9");

            Console.WriteLine("Until fate sees your return...");
            Console.Read();
        }
        private static void CreateCharacter()
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         What is your name?           ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string playerName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   What is your character name?   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

            string characterName = Console.ReadLine();


            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   What is your character level?   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
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
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("      What is your alignment?      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1: Lawful Good");
            Console.WriteLine("2: Neutral Good");
            Console.WriteLine("3: Chaotic Good");
            Console.WriteLine("4: Lawful Nuetral");
            Console.WriteLine("5: True Nuetral");
            Console.WriteLine("6: Chaotic Neutral");
            Console.WriteLine("7: Lawful Evil");
            Console.WriteLine("8: Neutral Evil");
            Console.WriteLine("9: Chaotic Evil");
            Console.WriteLine("10: Unaligned");


            bool characterAlignmentStatus = false;
            string characterAlignment;
            do
            {
                characterAlignment = Console.ReadLine();

                switch (characterAlignment)
                {
                    case "1":
                        characterAlignment = "Lawful Good";
                        characterAlignmentStatus = true;
                        break;
                    case "2":
                        characterAlignment = "Neutral Good";
                        characterAlignmentStatus = true;
                        break;
                    case "3":
                        characterAlignment = "Chaotic Good";
                        characterAlignmentStatus = true;
                        break;
                    case "4":
                        characterAlignment = "Lawful Neutral";
                        characterAlignmentStatus = true;
                        break;
                    case "5":
                        characterAlignment = "True Neutral";
                        characterAlignmentStatus = true;
                        break;
                    case "6":
                        characterAlignment = "Chaotic Neutral";
                        characterAlignmentStatus = true;
                        break;
                    case "7":
                        characterAlignment = "Lawful Evil";
                        characterAlignmentStatus = true;
                        break;
                    case "8":
                        characterAlignment = "Neutral Evil";
                        characterAlignmentStatus = true;
                        break;
                    case "9":
                        characterAlignment = "Chaotic Evil";
                        characterAlignmentStatus = true;
                        break;
                    case "10":
                        characterAlignment = "Unaligned";
                        characterAlignmentStatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        characterAlignmentStatus = false;
                        break;
                }
            } while (!characterAlignmentStatus);


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("     What is your background?      ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
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



            //Hello if you're seeing this!
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        What is your race?         ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Aarakocra");
            Console.WriteLine("2. Aasimar");
            Console.WriteLine("3. Bugbear");
            Console.WriteLine("4. Centaur");
            Console.WriteLine("5. Changeling");
            Console.WriteLine("6. Dragonborn");
            Console.WriteLine("7. Dwarf");
            Console.WriteLine("8. Elf");
            Console.WriteLine("9. Fairy");
            Console.WriteLine("10. Feral Tiefling");
            Console.WriteLine("11. Firbolg");
            Console.WriteLine("12. Genasi");
            Console.WriteLine("13. Gith");
            Console.WriteLine("14. Gnome");
            Console.WriteLine("15. Goblin");
            Console.WriteLine("16. Goliath");
            Console.WriteLine("17. Grung");
            Console.WriteLine("18. Half Elf");
            Console.WriteLine("19. Half Orc");
            Console.WriteLine("20. Halfling");
            Console.WriteLine("21. Harengon");
            Console.WriteLine("22. Hobgoblin");
            Console.WriteLine("23. Human");
            Console.WriteLine("24. Kalashtar");
            Console.WriteLine("25. Kenku");
            Console.WriteLine("26. Kobold");
            Console.WriteLine("27. Leonin");
            Console.WriteLine("28. Lineages");
            Console.WriteLine("29. Lizardfolk");
            Console.WriteLine("30. Locathah");
            Console.WriteLine("31. Loxodon");
            Console.WriteLine("32. Minotaur");
            Console.WriteLine("33. Orc");
            Console.WriteLine("34. Orc of Eberron");
            Console.WriteLine("35. Orc of Exandria");
            Console.WriteLine("36. Owlin");
            Console.WriteLine("37. Satyr");
            Console.WriteLine("38. Shifter");
            Console.WriteLine("39. Simic Hybrid");
            Console.WriteLine("40. Tabaxi");
            Console.WriteLine("41. Tiefling");
            Console.WriteLine("42. Tortle");
            Console.WriteLine("43. Triton");
            Console.WriteLine("44. Vedalken");
            Console.WriteLine("45. Verdan");
            Console.WriteLine("46. Warforged");
            Console.WriteLine("47. Yuanti Pureblood");

            bool characterRaceStatus = false;
            string characterRace;
            do
            {
                characterRace = Console.ReadLine();
                switch (characterRace)
                {
                    case "1":
                        characterRace = "Aarakocra";
                        characterRaceStatus = true;
                        break;
                    case "2":
                        characterRace = "Aasimar";
                        characterRaceStatus = true;
                        break;
                    case "3":
                        characterRace = "Bugbear";
                        characterRaceStatus = true;
                        break;
                    case "4":
                        characterRace = "Centaur";
                        characterRaceStatus = true;
                        break;
                    case "5":
                        characterRace = "Changeling";
                        characterRaceStatus = true;
                        break;
                    case "6":
                        characterRace = "Dragonborn";
                        characterRaceStatus = true;
                        break;
                    case "7":
                        characterRace = "Dwarf";
                        characterRaceStatus = true;
                        break;
                    case "8":
                        characterRace = "Elf";
                        characterRaceStatus = true;
                        break;
                    case "9":
                        characterRace = "Fairy";
                        characterRaceStatus = true;
                        break;
                    case "10":
                        characterRace = "Feral Tiefling";
                        characterRaceStatus = true;
                        break;
                    case "11":
                        characterRace = "Firbolg";
                        characterRaceStatus = true;
                        break;
                    case "12":
                        characterRace = "Genasi";
                        characterRaceStatus = true;
                        break;
                    case "13":
                        characterRace = "Gith";
                        characterRaceStatus = true;
                        break;
                    case "14":
                        characterRace = "Gnome";
                        characterRaceStatus = true;
                        break;
                    case "15":
                        characterRace = "Goblin";
                        characterRaceStatus = true;
                        break;
                    case "16":
                        characterRace = "Goliath";
                        characterRaceStatus = true;
                        break;
                    case "17":
                        characterRace = "Grung";
                        characterRaceStatus = true;
                        break;
                    case "18":
                        characterRace = "Half Elf";
                        characterRaceStatus = true;
                        break;
                    case "19":
                        characterRace = "Half Orc";
                        characterRaceStatus = true;
                        break;
                    case "20":
                        characterRace = "Halfling";
                        characterRaceStatus = true;
                        break;
                    case "21":
                        characterRace = "Harengon";
                        characterRaceStatus = true;
                        break;
                    case "22":
                        characterRace = "Hobgoblin";
                        characterRaceStatus = true;
                        break;
                    case "23":
                        characterRace = "Human";
                        characterRaceStatus = true;
                        break;
                    case "24":
                        characterRace = "Kalashtar";
                        characterRaceStatus = true;
                        break;
                    case "25":
                        characterRace = "Kenku";
                        characterRaceStatus = true;
                        break;
                    case "26":
                        characterRace = "Kobold";
                        characterRaceStatus = true;
                        break;
                    case "27":
                        characterRace = "Leonin";
                        characterRaceStatus = true;
                        break;
                    case "28":
                        characterRace = "Lineages";
                        characterRaceStatus = true;
                        break;
                    case "29":
                        characterRace = "Lizardfolk";
                        characterRaceStatus = true;
                        break;
                    case "30":
                        characterRace = "Locathah";
                        characterRaceStatus = true;
                        break;
                    case "31":
                        characterRace = "Loxodon";
                        characterRaceStatus = true;
                        break;
                    case "32":
                        characterRace = "Minotaur";
                        characterRaceStatus = true;
                        break;
                    case "33":
                        characterRace = "Orc";
                        characterRaceStatus = true;
                        break;
                    case "34":
                        characterRace = "Orc of Eberron";
                        characterRaceStatus = true;
                        break;
                    case "35":
                        characterRace = "Orc of Exandria";
                        characterRaceStatus = true;
                        break;
                    case "36":
                        characterRace = "Owlin";
                        characterRaceStatus = true;
                        break;
                    case "37":
                        characterRace = "Satyr";
                        characterRaceStatus = true;
                        break;
                    case "38":
                        characterRace = "Shifter";
                        characterRaceStatus = true;
                        break;
                    case "39":
                        characterRace = "Simic Hybrid";
                        characterRaceStatus = true;
                        break;
                    case "40":
                        characterRace = "Tabaxi";
                        characterRaceStatus = true;
                        break;
                    case "41":
                        characterRace = "Tiefling";
                        characterRaceStatus = true;
                        break;
                    case "42":
                        characterRace = "Tortle";
                        characterRaceStatus = true;
                        break;
                    case "43":
                        characterRace = "Triton";
                        characterRaceStatus = true;
                        break;
                    case "44":
                        characterRace = "Vedalken";
                        characterRaceStatus = true;
                        break;
                    case "45":
                        characterRace = "Verdan";
                        characterRaceStatus = true;
                        break;
                    case "46":
                        characterRace = "Warforged";
                        characterRaceStatus = true;
                        break;
                    case "47":
                        characterRace = "Yuanti Pureblood";
                        characterRaceStatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        characterRaceStatus = false;
                        break;
                }
            } while (!characterRaceStatus);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        What is your class?        ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Barbarian");
            Console.WriteLine("2. Bard");
            Console.WriteLine("3. Cleric");
            Console.WriteLine("4. Druid");
            Console.WriteLine("5. Fighter");
            Console.WriteLine("6. Monk");
            Console.WriteLine("7. Paladin");
            Console.WriteLine("8. Ranger");
            Console.WriteLine("9. Rogue");
            Console.WriteLine("10. Sorcerer");
            Console.WriteLine("11. Warlock");
            Console.WriteLine("12. Wizard");
            Console.WriteLine("13. Artificer");

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
                        characterClass = "Rogue";
                        characterClassStatus = true;
                        break;
                    case "9":
                        characterClass = "Sorcerer";
                        characterClassStatus = true;
                        break;
                    case "10":
                        characterClass = "Warlock";
                        characterClassStatus = true;
                        break;
                    case "11":
                        characterClass = "Wizard";
                        characterClassStatus = true;
                        break;
                    case "12":
                        characterClass = "Artificer";
                        characterClassStatus = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        characterClassStatus = false;
                        break;
                }
            } while (!characterClassStatus);

            Character character = new Character(playerName, characterName, characterBackground, characterAlignment,
                characterLevel, characterRace, characterClass);
            characters.Add(character);

            WriteToCsv(characters);


            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" You have created a new character! ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;

        }
        static void ReviewCharacter()
        {

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("           Characters              ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************");
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
                        Console.WriteLine();
                        Console.WriteLine();

                    });
                    
                    
                    

        }
    }
}
    

