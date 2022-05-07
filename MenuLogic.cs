using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreation
{
    internal class MenuLogic
    {
        // Menu logic 
        public static void Menu()
        {
            do
            {
                Console.WriteLine("Press:");
                Console.WriteLine("A: Create new character");
                Console.WriteLine("B: View existing characters");

                ConsoleKeyInfo temp = Console.ReadKey();

                switch (temp.Key)
                {
                    case ConsoleKey.A:
                        CharacterCreation.Create();
                        break;

                    case ConsoleKey.B:
                        CharacterCreation.Display();
                        break;

                    default:
                        break;
                }
            }while(true);
        }
    }
}
