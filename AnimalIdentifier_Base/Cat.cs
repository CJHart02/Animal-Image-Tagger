using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Cat : DogOrCat
    {
        private static bool isCat;

        public bool returnIsCat()
        {
            return isCat;
        }

        public void catTest(string name)
        {
            isCat = (name == "cat") ? true : isCat;

        }
    }
}
