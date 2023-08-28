using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster
{
    public class CyberpunkCharacter
    {
        [Index(0)]
        public string PlayerName { get; set; }
        public string CharacterHandle { get; set; }
        public string CharacterRole { get; set;}
        public int CharacterPoints { get; set; }
        public int CharacterIntelligence { get; set; }
        public int CharacterReflexes { get; set; }
        public int CharacterCool { get; set;}
        public int CharacterTechnicalAbility { get; set; }
        public int CharacterLuck { get; set; }
        public int CharacterAttractiveness { get; set; }
        public int CharacterMovementAllowance { get; set; }
        public int CharacterRun { get; set; }
        public int CharacterLeap { get; set; }
        public int CharacterEmpathy { get; set; }

        public CyberpunkCharacter() { } //Neccesary to prevent CSV error
        public CyberpunkCharacter(string playerName, string characterHandle, string characterRole, int characterPoints, int characterIntelligence, int characterReflexes, int characterCool, int characterTechnicalAbility, int characterLuck, int characterAttractiveness, int characterMovementAllowance, int characterRun, int characterLeap, int characterEmpathy)
        {
            PlayerName = playerName;
            CharacterHandle = characterHandle;
            CharacterRole = characterRole;
            CharacterPoints = characterPoints;
            CharacterIntelligence = characterIntelligence;
            CharacterReflexes = characterReflexes;
            CharacterCool = characterCool;
            CharacterTechnicalAbility = characterTechnicalAbility;
            CharacterLuck = characterLuck;
            CharacterAttractiveness = characterAttractiveness;
            CharacterMovementAllowance = characterMovementAllowance;
            CharacterRun = characterRun;
            CharacterLeap = characterLeap;
            CharacterEmpathy = characterEmpathy;
        }
    }
}
