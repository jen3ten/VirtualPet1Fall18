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
            Program program = new Program();
            PetStatus();
        }

        static void PetStatus()
        {
            Console.WriteLine("Fluffy's Current Vitals:");
            Console.WriteLine("Hunger Level- {0}", fluffy.Hunger);
            Console.WriteLine("Fatigue Level- {0}", fluffy.Fatigue);
            Console.WriteLine("Health Level- {0}", fluffy.Health);

        }
    }
}
