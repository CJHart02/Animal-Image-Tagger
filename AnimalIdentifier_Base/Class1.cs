using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class DogOrCat
    {
        private bool isDog;
        private bool isCat;

        public DogOrCat() { }

        protected void dogTest(string word)
        {
            if (word == "dog" || word == "dogs")
            {
                isDog = true;
            }
        }

        protected void catTest(string word)
        {
            if (word == "cat" || word == "cats")
            {
                isCat = true;
            }
        }

        public void sentenceTest(string word)
        {
            dogTest(word);
            catTest(word);
        }

        protected bool isDogTrue()
        {
            if (isDog == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected bool isCatTrue()
        {
            if (isCat == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void output()
        {
            if ((isDogTrue() == true) && (isCatTrue() == true))
            {
                Console.WriteLine("The sentence is talking about dogs and cats.");
            }
            else if ((isDogTrue() == true) && (isCatTrue() == false))
            {
                Console.WriteLine("The sentence is talking about dogs.");
            }
            else if ((isDogTrue() == false) && (isCatTrue() == true))
            {
                Console.WriteLine("The sentence is talking about cats.");
            }
            else
            {
                Console.WriteLine("The sentence is not talking about dogs or cats.");
            }
        }
    }
}
