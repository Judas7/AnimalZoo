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
        private enum SPECIES { CAT, DOG, BIRD};

        private string name;
        private SPECIES species;
        private bool canFly;

        private static int currentYear = 2020;
        private int birthyear;

        public Animal(int age)
        {
            this.birthyear = Animal.currentYear - age;
        }

        public int GetAge()
        {
            return Animal.currentYear - this.birthyear;
        }

        private int age;

        public Animal(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
        
        public string GetName()
        {
            return name;
        }

        public SPECIES GetSpecies()
        {
            return SPECIES;
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
