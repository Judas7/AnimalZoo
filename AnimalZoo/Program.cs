using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Program
    {
        /*static void Main(string[] args) 
        {
            Animal[] allAnimals; //The object "allAnimals" is of the class "Animal"

            allAnimals = new Animal[4]; //A list with 4 empty spots gets created in "allAnimals"

            allAnimals[0] = new Cat("Kurre"); //A instans of the class "Cat" gets created with help of the constructor "Cat". 

            allAnimals[1] = new Dog("Kenneth"); //A instans of the class "Dog" gets created with help of the constructor "Dog". 

            allAnimals[2] = new Cat("Bamse"); //A instans of the class "Cat" gets created with help of the constructor "Cat". 

            allAnimals[3] = new Bird("Johnny"); //A instans of the class "Bird" gets created with help of the constructor "Bird". 

            foreach (Animal a in allAnimals) //The method "IntroduceYourself" gets called for every object in the list "allAnimals"
            {
                Console.WriteLine("Nu kommer " + a.name); //The first time it loops "a" is 0 which is the index of a Cat named "Kurre"
                a.IntroduceYourself();
                Console.WriteLine();
            }
            Console.ReadKey();
        }*/

        /*public static void Main(String[] args)
        {
            Animal kurre = new Cat("Kurre");
            Animal vilma = new Dog("Vilma");

            kurre.age = 6;
            vilma.age = 3;

            kurre.IntroduceYourself();
            vilma.IntroduceYourself();
            Console.ReadKey();
        }*/

        public class Animal
        {
            private static int currentYear = 2019;
            private int birthyear;

            public Animal(int age)
            {
                this.birthyear = Animal.currentYear - age;
            }

            public int GetAge()
            {
                return Animal.currentYear - this.birthyear;
            }
            
        }


    }
}
