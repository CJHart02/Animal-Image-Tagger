using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class CallAnimal
    {
        public void callTest(Animal anm, string name, double conf)
        {
            anm.imageTest(name, conf);
        }
    }
}
