using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Dog : Animal
    {
        public override void imageTest(string name)
        {
            isAnimal = (name == "dog") ? true : false;

            output();
        }

        protected override void output()
        {
            if (isAnimal == true)
            {
                Console.WriteLine("This image contains a dog.");
            }
        }

    }
}
