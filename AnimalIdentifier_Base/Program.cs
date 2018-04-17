using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class Program
    {

        static void Main()
        {
            // Get the path and filename to process from the user.
            Console.WriteLine("Analyze an image:");
            Console.Write("Enter the path to an image you wish to analzye: ");
            string imageFilePath = Console.ReadLine();

            ImageTagger animalImageTagger = new ImageTagger();
            List<Tag> tags = animalImageTagger.GetTagsForImage(imageFilePath);

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

            Console.WriteLine("Press Any Key to Continue.");
            Console.ReadLine();
        }
    }
}
