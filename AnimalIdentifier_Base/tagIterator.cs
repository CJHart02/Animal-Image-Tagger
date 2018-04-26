using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class tagIterator
    {
        public void TagIterator(string filepath)
        {
            getTags animalImageTagger = new getTags();
            List<Tag> tags = animalImageTagger.animalTags(filepath);

            CallAnimal a = new CallAnimal();
            Cat cat = new Cat();
            Bird bird = new Bird();
            Dog dog = new Dog();

            foreach (Tag tag in tags)
            {
                //Console.WriteLine(tag.confidence);
                a.callTest(cat, tag.name, tag.confidence);
                a.callTest(dog, tag.name, tag.confidence);
                a.callTest(bird, tag.name, tag.confidence);
            }
        }
    }
}
