using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    internal class CharacterCreation
    {
        // Variables only used in this class.
        static List<Character> CharacterList = new List<Character>();
        static int[] Attributes = new int[6];
        static Roles Role;
        static string? Name;
        static string[] Attribute = new string[] { "Strength", "Intelligence", "Wisdom", "Dexterity", "Constitution", "Charisma" };

        // Method calling the other methods.
        public static void Create()
        {
            Console.Clear();
            GetStats();
            Console.Clear();
            GetRole();
            Console.Clear();
            SetValues();
            Console.Clear();
        }

        // Simullates rolling 3 dice.
        public static int DiceRoll()
        {
            Random random = new Random();
            int a = random.Next(1, 7);
            int b = random.Next(1, 7);
            int c = random.Next(1, 7);
            return a + b + c;
        }

        // Asigns the dice-rolls to each stat.
        public static void GetStats()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Stats:");
                for (int i = 0; i < 6; i++)
                {
                    Attributes[i] = DiceRoll();
                    Console.WriteLine(Attribute[i] + ": " + Attributes[i]);
                }
                Console.WriteLine("Press:");
                Console.WriteLine("A: To keep stats");
                Console.WriteLine("B: To reroll stats");
                ConsoleKeyInfo temp = Console.ReadKey();

                switch (temp.Key)
                {
                    case ConsoleKey.A:
                        loop = false;
                        break;

                    case ConsoleKey.B:
                        Console.Clear();
                        break;

                    default:
                        break;
                }

            } while (loop);
        }
        
        // Lets the user choose a role.
        public static void GetRole()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Choose role:");
                Console.WriteLine("A: Fighter");
                Console.WriteLine("B: Mage");
                Console.WriteLine("C: Cleric");
                Console.WriteLine("D: Bard");
                Console.WriteLine("E: Rogue");
                Console.WriteLine("F: Paladin");
                Console.WriteLine("G: Barbarian");
                ConsoleKeyInfo temp = Console.ReadKey();

                switch (temp.Key)
                {
                    case ConsoleKey.A:
                        Role = Roles.Fighter;
                        loop = false;
                        break;
                    case ConsoleKey.B:
                        Role = Roles.Mage;
                        loop = false;
                        break;
                    case ConsoleKey.C:
                        Role = Roles.Cleric;
                        loop = false;
                        break;
                    case ConsoleKey.D:
                        Role = Roles.Bard;
                        loop = false;
                        break;
                    case ConsoleKey.E:
                        Role = Roles.Rogue;
                        loop = false;
                        break;
                    case ConsoleKey.F:
                        Role = Roles.Paladin;
                        loop = false;
                        break;
                    case ConsoleKey.G:
                        Role = Roles.Barbarian;
                        loop = false;
                        break;
                    default:
                        break;
                }
            } while (loop);

            
        }

        // Adds the objects, with the chosen values, to a list.
        public static void SetValues()
        {
            Console.WriteLine("Choose a name for your character:");
            Name = Console.ReadLine();
            Abilities a = new Abilities(Attributes[0], Attributes[1], Attributes[2], Attributes[3], Attributes[4], Attributes[5]);
            CharacterList.Add(new Character(Name, Role, a));
        }

        // Displays all the character properties.
        public static void Display()
        {
            Console.Clear();
            foreach (var Character in CharacterList)
            {
                Console.WriteLine(Character.Name + ":");
                Console.WriteLine(Character.Role);
                Console.WriteLine("Strenght: " + Character.Abilities.Strength);
                Console.WriteLine("Intelligens: " + Character.Abilities.Intelligens);
                Console.WriteLine("Wisdom: " + Character.Abilities.Wisdom);
                Console.WriteLine("Dexterity: " + Character.Abilities.Dexterity);
                Console.WriteLine("Constitution: " + Character.Abilities.Constitution);
                Console.WriteLine("Charisma: " + Character.Abilities.Charisma);
                Console.WriteLine("");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
