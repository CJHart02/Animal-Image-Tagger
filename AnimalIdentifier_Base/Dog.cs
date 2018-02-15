using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Dog
    {
        private bool isDog;

        public bool returnIsDog()
        {
            return isDog;
        }

        public void dogTest(string name)
        {
            isDog = (name == "dog") ? true : false;
            //Console.WriteLine(isDog);
        }
    }
}
