using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalZoo
{
    class Bird : Animal
    {
        public Bird(string name, int age) : base(age)
        {
            /*initiera attributen i objektet*/
            SetSpecies(SPECIES.BIRD);
            SetCanFly(true);
            SetName(name);
        }
        public override void IntroduceYourself()
        {
            Console.WriteLine("Pip. Jag är en fågel som heter " + GetName() + ".");
            base.IntroduceYourself();
        }
    }
}
