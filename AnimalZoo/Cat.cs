using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(age)
        {
            /*initiera attributen i objektet*/
            SetSpecies(SPECIES.CAT);
            SetCanFly(false);
            SetName(name);
        }
        /*public override void IntroduceYourself() //This overwrites the function thats in the parent
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + name); 
            base.IntroduceYourself(); //The parents functions is also called
        }*/
        public override void IntroduceYourself()
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + GetName() + ".");
            Console.WriteLine("Jag är " + GetAge() + " år gammal.");
        }
    }


}
