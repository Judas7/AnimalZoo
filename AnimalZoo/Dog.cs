using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {
        public Dog(string name, int age) : base(age)
        {
            /*initiera attributen i objektet*/
            SetSpecies(SPECIES.DOG);
            SetCanFly(false);
            SetName(name);
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Vov. Jag är en hund som heter " + GetName() + ".");
            Console.WriteLine("Jag är " + GetAge() + " år gammal.");
        }

    }
}
