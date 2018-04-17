using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class confidenceCheck
    {
        public static bool confCheck(double conf)
        {
            if (conf >= 0.8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
