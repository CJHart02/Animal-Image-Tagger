using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    public class tagIterator
    {
        public tagIterator()
        {

        }

        public void TagIterator(string filepath, Animal animal)
        {
            getTags animalImageTagger = new getTags();
            List<Tag> tags = animalImageTagger.animalTags(filepath);

            CallAnimal a = new CallAnimal();

            foreach (Tag tag in tags)
            {
                a.callTest(animal, tag.name, tag.confidence);
            }
        }
    }
}
