﻿using System;
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

            tagIterator animalTag = new tagIterator();

            animalTag.TagIterator(imageFilePath);
           
            Console.WriteLine("Press Any Key to Continue.");
            Console.ReadLine();
        }
    }
}
