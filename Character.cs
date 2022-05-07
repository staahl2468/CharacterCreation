using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
   // Makes properties and constructors.
    public enum Roles { Fighter = 1, Mage, Cleric, Bard, Rogue, Paladin, Barbarian }
    internal class Character
    {

        public string Name { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
        public Roles Role { get; set; }
        public Abilities Abilities { get; set; }

        public Character()
        {

        }
        public Character(string name, Roles role, Abilities abilities)
        {
            Name = name;
            Role = role;
            Abilities = abilities;
        }
    }

    public class Abilities
    {
        public int Strength { get; set; }
        public int Intelligens { get; set; }
        public int Wisdom { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Charisma { get; set; }

        public Abilities(int strength, int intelligens, int wisdom, int dexterity, int constitution, int charisma)
        {
            Strength = strength;    
            Intelligens = intelligens;
            Wisdom = wisdom;
            Dexterity = dexterity;
            Constitution = constitution;
            Charisma = charisma;
        }
    }
}
