using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_SummerFall
{
    class VirtualPet
    {
        private int hunger;
        private int water;
        private int insulin;

        public VirtualPet()
        {
            this.hunger = 30;
            this.water = 30;
            this.insulin = 40;
        }


        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Waste
        {
            get { return this.water; }
            set { this.water = value; }
        }

        public int Insulin
        {
            get { return this.insulin; }
            set { this.insulin = value; }
        }
        public void DogInfo()
        {
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Water: " + this.water);
            Console.WriteLine("Insulin: " + this.insulin);
        }

        public void FeedDog()
        {
            hunger += 10;
            water -= 5;
            insulin -= 4;
            Console.WriteLine("\nRanger's new stats are:");
        }
        public void WaterDog()
        {
            water += 10;
            hunger -= 4;
            insulin -= 5;
            Console.WriteLine("\nRanger's new stats are:");
        }
        public void GiveInsulin()
        {
            insulin += 10;
            water -= 5;
            hunger -= 5;
            Console.WriteLine("\nRanger's new stats are:");
        }

    }
}
