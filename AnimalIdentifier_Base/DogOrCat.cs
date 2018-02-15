using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class DogOrCat
    {

        private static Dog dog = new Dog();
        private static Cat cat = new Cat();

        public DogOrCat() {}


        private bool isDog;
        private bool isCat;

        public void imageTest(string name)
        {
            
            dog.dogTest(name);
            cat.catTest(name);
            getIsCat();
            getIsDog();
        }

        public void getIsDog()
        {
            isDog = dog.returnIsDog();
        }

        public void getIsCat()
        {
            isCat = cat.returnIsCat();
        }

        public void output()
        {
            if ((this.isDog == true) && (this.isCat == true))
            {
                Console.WriteLine("This image has a dog and a cat.");
            }
            else if ((this.isDog == true) && (this.isCat == false))
            {
                Console.WriteLine("This image has a dog.");
            }
            else if ((this.isDog == false) && (this.isCat == true))
            {
                Console.WriteLine("This image has a cat.");
            }
            else
            {
                Console.WriteLine("This image has neither a dog nor a cat.");
            }
        }
    }
}
