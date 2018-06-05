using System.Collections.Generic;
using System.Linq;

namespace CW_Lecture_1_9
{
    public class AnimalCollection
    {
        protected Animal[] animals;

        public AnimalCollection()
        {
            animals = new Animal[8];
        }

        public AnimalCollection(IEnumerable<Animal> anmals)
        {
            this.animals = animals.ToArray();
        }


        public bool Contains(Animal animal)
        {
            foreach (var singleAnimal in animals)
            {
                if (singleAnimal.Equals(animal))
                    /*
                     *bool Equals(object obj) {
                     *     return this == obj;
                     *
                     * }
                     */
                    return true;
            }

            return false;
        }


        
    }
}