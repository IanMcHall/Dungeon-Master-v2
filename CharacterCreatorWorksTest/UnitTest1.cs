using DungeonMaster;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CharacterTest
{
    [TestClass]
    public class CharacterTest
    {
        [TestMethod]
        public void CharacterCreatorWorks()
        {
            //Arrange 
            string playerName = "Player";
            string characterName = "Character";
            string characterLevel = "1";
            string characterAlignment = "Chaotic Good";
            string characterRace = "Human";
            string characterClass = "Bard";
            int characterStrength = 5;
            int characterDexterity = 6;
            int characterConstitution = 7;
            int characterIntelligence = 8;
            int characterWisdom = 9;
            int characterCharisma = 10;


            //Act
            var character = new Character(playerName, characterName, characterLevel, characterAlignment,
                characterRace, characterClass, characterStrength, characterDexterity, characterConstitution, characterIntelligence,
                characterWisdom, characterCharisma);

            //Assert

            Assert.AreEqual(playerName, character.PlayerName);
            Assert.AreEqual(characterName, character.CharacterName);
            Assert.AreEqual(characterLevel, character.CharacterLevel);
            Assert.AreEqual(characterAlignment, character.CharacterAlignment);
            Assert.AreEqual(characterRace, character.CharacterRace);
            Assert.AreEqual(characterClass, character.CharacterClass); 
            Assert.AreEqual(characterStrength, character.CharacterStrength);
            Assert.AreEqual(characterDexterity, character.CharacterDexterity);
            Assert.AreEqual(characterConstitution, character.CharacterConstitution);
            Assert.AreEqual(characterIntelligence, character.CharacterIntelligence);
            Assert.AreEqual(characterWisdom, character.CharacterWisdom);
            Assert.AreEqual(characterCharisma, character.CharacterCharisma);


        }
    }
}