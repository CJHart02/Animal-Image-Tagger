using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Cat : Animal
    {
        public override void imageTest(string name, double conf)
        {
            if (confidenceCheck.confCheck(conf) == true)
            {
                isAnimal = (name == "cat") ? true : false;

                output();
            }
        }

        protected override void output()
        {
            if (isAnimal == true)
            {
                Console.WriteLine("This image contains a cat.");
            }
        }
    }
}
