using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet1Fall18
{
    public class VirtualPet
    {
        //Fields
        private int hunger;

        //Properties
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Fatigue { get; set; }
        public int Health { get; set; }

        //Constructor
        public VirtualPet()
        {
            this.Hunger = 100;
            this.Fatigue = 100;
            this.Health = 100;
        }

        //Methods
        public void FeedMe()
        {
            this.Hunger = Hunger - 1;
            this.Fatigue = Fatigue + 1;
        }

        public void ExerciseMe()
        {
            this.Hunger = Hunger + 1;
            this.Health = Health + 1;
        }

        public void RestMe()
        {
            this.Fatigue = Fatigue - 1;
            this.Health = Health + 1;
        }
    }
}
