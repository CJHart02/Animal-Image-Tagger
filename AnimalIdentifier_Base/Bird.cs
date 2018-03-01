﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Bird : Animal
    {
        public override void imageTest(string name)
        {
            isAnimal = (name == "bird") ? true : false;

            output();
        }

        protected override void output()
        {
            if (isAnimal == true)
            {
                Console.WriteLine("This image contains a bird.");
            }
        }
    }

}
