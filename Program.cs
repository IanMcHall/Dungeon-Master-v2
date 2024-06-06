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
                Console.WriteLine("9. Exit");

                userSelection = Console.ReadLine();

                switch (userSelection)
                {
                    case "1":
                        SelectGame();
                        break;

                    case "2":
                        ReviewCharacter();
                        break;

                }
            } while (userSelection != "9");

            Console.WriteLine("Until fate sees your return...");
            Console.Read();
        }

        static void SelectGame()
        {
            string flair = "***********************************";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("         Select a game            ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(flair);
            Console.ForegroundColor = ConsoleColor.White;

            bool gameSelectionStatus =false;
            string gameSelection;

            do
            {
                Console.WriteLine("1. Dungeons & Dragons");
             

                gameSelection = Console.ReadLine();

                switch (gameSelection)
                {
                    case "1":
                        var task = CreateCharacter();
                        task.Wait();
                        gameSelectionStatus = true;
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        gameSelectionStatus = false;
                        break;
                }
            } while (!gameSelectionStatus);
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
            

            Character character = new Character(playerName, characterName, characterAlignment,
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
    }
}
