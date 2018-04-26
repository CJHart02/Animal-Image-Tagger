using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalIdentifier_Base
{
    class getTags
    {
        public List<Tag> animalTags(string filepath)
        {
            ImageTagger animalImageTagger = new ImageTagger();
            List<Tag> tags = animalImageTagger.GetTagsForImage(filepath);
            return tags;
        }
    }
}
