using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Cat : Animal
    {
        public Cat(string name)
        {
            /*initiera attributen i objektet*/
            species = SPECIES.CAT;
            canFly = false;
            base.name = name;
        }
        /*public override void IntroduceYourself() //This overwrites the function thats in the parent
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + name); 
            base.IntroduceYourself(); //The parents functions is also called
        }*/
        public override void IntroduceYourself()
        {
            Console.WriteLine("Mjau. Jag är en katt som heter " + this.name + ".");
            Console.WriteLine("Jag är " + this.age + " år gammal.");
        }
    }


}
