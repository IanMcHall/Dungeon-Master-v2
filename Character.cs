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
        public string CharacterBackground{ get; set; }
        public string CharacterAlignment { get; set; }
        public string CharacterRace { get; set; }
        public string CharacterClass { get; set; }
        
        public Character(){}
        public Character(string playerName, string characterName, string characterBackground, string characterAlignment, string characterLevel, string characterRace, string characterClass)
        {
            PlayerName = playerName;
            CharacterName = characterName;
            CharacterBackground = characterBackground;
            CharacterAlignment = characterAlignment;
            CharacterLevel = characterLevel;
            CharacterClass = characterClass;
            CharacterRace = characterRace;
        }
    }
}
