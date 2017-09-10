using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet_SummerFall
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPet Ranger = new VirtualPet();


            {   //begin user interaction
                Console.WriteLine("Ranger's current health stats are: ");
                Ranger.DogInfo();
                Console.WriteLine();//added for readability

                List<string> careOptions = new List<string>();
                careOptions.Add("1. Feed");
                careOptions.Add("2. Water");
                careOptions.Add("3. Give Insulin shot");

                for (int i = 0; i < 10; i++) //loop will print options, read input, and adjust variables accordingly
                {
                    foreach (string option in careOptions)
                    {
                        Console.WriteLine(option);
                    }

                    Console.WriteLine("Enter the number for the task you want to perform. Press any other key to quit.");
                    string userChoice = Console.ReadLine();
                    if (userChoice == "1")
                    {
                        Ranger.FeedDog();   //will adjust stats and
                        Ranger.DogInfo();   //print updated stats
                        Console.WriteLine("\n=========================\n");  //divider for improved user readability
                    }
                    else if (userChoice == "2")
                    {
                        Ranger.WaterDog();
                        Ranger.DogInfo();
                        Console.WriteLine("\n=========================\n");
                    }
                    else if (userChoice == "3")
                    {
                        Ranger.GiveInsulin();
                        Ranger.DogInfo();
                        Console.WriteLine("\n=========================\n");
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }

            }

        }
    }
}
