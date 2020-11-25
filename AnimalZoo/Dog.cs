using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Dog : Animal
    {
        public Dog(string name)
        {
            /*initiera attributen i objektet*/
            species = SPECIES.DOG;
            canFly = false;
            base.name = name;
        }

        public override void IntroduceYourself()
        {
            Console.WriteLine("Vov. Jag är en hund som heter " + this.name + ".");
            Console.WriteLine("Jag är " + this.age + " år gammal.");
        }

    }
}
