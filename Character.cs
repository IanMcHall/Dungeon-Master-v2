using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace DungeonMaster
{
    public class Character
    {
        [Index(0)]
        public string PlayerName { get; set; }
        public string CharacterName { get; set; }
        public string CharacterLevel { get; set; }
        public string CharacterAlignment { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterClass { get; set; }
        public int CharacterStrength { get; set;}
        public int CharacterDexterity { get; set;}
        public int CharacterConstitution { get; set; }
        public int CharacterIntelligence { get; set; }  
        public int CharacterWisdom  { get; set; }
        public int CharacterCharisma { get; set; }
        
        public Character(){}
        public Character(string playerName, string characterName, string characterAlignment, string characterLevel, string characterRace, string characterClass, int characterStrength, int characterDexterity, int characterConstitution, int characterIntelligence, int characterWisdom, int characterCharisma)
        {
            PlayerName = playerName;
            CharacterName = characterName;
            CharacterAlignment = characterAlignment;
            CharacterLevel = characterLevel;
            CharacterClass = characterClass;
            CharacterRace = characterRace;
            CharacterStrength = characterStrength;
            CharacterDexterity = characterDexterity;
            CharacterConstitution = characterConstitution;
            CharacterIntelligence = characterIntelligence;
            CharacterWisdom = characterWisdom; 
            CharacterCharisma = characterCharisma;


        }
    }
}
