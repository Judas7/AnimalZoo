using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        static void Main(string[] args) 
        {
            Animal[] allAnimals; //The object "allAnimals" get sent to the class "Animal"

            allAnimals = new Animal[4]; //4 empty Animals gets created in "allAnimals"

            allAnimals[0] = new Cat("Kurre"); //A new cat gets created and put in the first spot in the array

            allAnimals[1] = new Dog("Kenneth"); //A new dog gets created and put in the second spot in the array

            allAnimals[2] = new Cat("Bamse"); //A new cat gets created and put in the third spot in the array

            allAnimals[3] = new Bird("Johnny"); //A new Bird gets created and put in the fourth spot in the array

            foreach (Animal a in allAnimals)
            {
                Console.WriteLine("Nu kommer " + a.name);
                a.IntroduceYourself();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
