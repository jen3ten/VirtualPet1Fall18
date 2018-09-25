using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet1Fall18
{
    class Program
    {

        VirtualPet fluffy = new VirtualPet();

        static void Main(string[] args)
        {
            int menuAction = 0;
            Intro();
            PetStatus();
            menuAction = Menu();

            switch (menuAction)
            {
                case 1: Console.WriteLine("Let's eat!");
                    break;
                case 2: Console.WriteLine("Good Night, Fluffy");
                    break;
                case 3: Console.WriteLine("Let's play!");
                    break;
                case 4: PetStatus();
                    break;
                case 0:
                    Console.WriteLine("OK, press any key when you want to interact with Fluffy");
                    break;
                default:
                    break;
                    
            }
        }

        static void Intro()
        {
            Console.WriteLine("**** Congratuations! ****");
            Console.WriteLine("You are now the proud parent of Fluffy");
            Console.WriteLine("Fluffy needs to eat, sleep and exercise in order to stay healthy");
        }

        static void PetStatus()
        {
            Program program = new Program();

            Console.WriteLine();
            Console.WriteLine("Fluffy's Current Vitals:");
            Console.WriteLine("Hunger Level- {0}", program.fluffy.Hunger);
            Console.WriteLine("Fatigue Level- {0}", program.fluffy.Fatigue);
            Console.WriteLine("Health Level- {0}", program.fluffy.Health);
        }

        static int Menu()
        {
            int action = 0;
            Console.WriteLine();
            Console.WriteLine("How would you like to take care of Fluffy?");
            Console.WriteLine("Enter 1 to Feed Fluffy");
            Console.WriteLine("Enter 2 to Rock Fluffy to Sleep");
            Console.WriteLine("Enter 3 to Play with Fluffy");
            Console.WriteLine("Enter 4 to see Fluffy's Vitals");
            Console.WriteLine("Enter 0 to do nothing");
            action = int.Parse(Console.ReadLine());
            while(action < 0 || action > 4)
            {
                Console.WriteLine("Please enter 0, 1, 2, 3, or 4");
                action = int.Parse(Console.ReadLine());
            }
            return action;
        }


    }
}
