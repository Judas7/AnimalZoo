using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    public class Animal
    {
        public enum SPECIES { CAT, DOG, BIRD};

        private string name;
        private SPECIES species;
        private bool canFly;

        private static int currentYear = 2020;
        private int birthYear;

        public Animal(int age)
        {
            this.birthYear = Animal.currentYear - age;
        }

        public int GetAge()
        {
            return Animal.currentYear - this.birthYear;
        }

        public static void SetYear(int year)
        {
            currentYear = year;
        }
        
        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public SPECIES GetSpecies()
        {
            return species;
        }

        public void SetSpecies(SPECIES species)
        {
            this.species = species;
        }

        public bool GetCanFly()
        {
            return canFly;
        }

        public void SetCanFly(bool canFly)
        {
            this.canFly = canFly;
        }

        public virtual void IntroduceYourself()
        {
            if (canFly == true) //If the animal can fly write this
            {
                Console.WriteLine("Jag kan flyga! ");
            }
            else //If the animal can't fly write this. 
            {
                Console.WriteLine("Jag kan inte flyga :(");
            }
            Console.WriteLine("Min art är en:" + species);
            
        }
    }
}
