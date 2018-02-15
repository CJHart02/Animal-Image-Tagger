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

        public void imageTest(string name)
        {
            
            dog.dogTest(name);
            cat.catTest(name);
        }

        public void output()
        {
            Console.WriteLine(dog.returnIsDog());
            Console.WriteLine(cat.returnIsCat());
            if ((dog.returnIsDog() == true) && (cat.returnIsCat() == true))
            {
                Console.WriteLine("This image comtains a dog and a cat.");
            }
            else if ((dog.returnIsDog() == true) && (cat.returnIsCat() == false))
            {
                Console.WriteLine("This image has a dog.");
            }
            else if ((dog.returnIsDog() == false) && (cat.returnIsCat() == true))
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
