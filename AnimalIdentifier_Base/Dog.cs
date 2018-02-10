using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Dog : DogOrCat
    {
        private bool isDog;

        protected bool returnIsDog()
        {
            return isDog;
        }

        protected void dogTest(string name)
        {
            isDog = (name == "dog") ? true : false;
        }
    }
}
