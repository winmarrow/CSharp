using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Lecture_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice_1_animals();
            
            
            Console.ReadKey();

        }


        static void Exercice_1_animals()
        {
            Animal animal = new Animal("Tiger");

            var animals = new[]
            {
                new Animal("Buffalo"), new Animal("Rabbit"), new Animal("Puma"),
            };

            foreach (Animal singleAnimal in animals)
            {
                Console.WriteLine($"Type: {singleAnimal.Type} | Hunger: {singleAnimal.Hunger}");
            }

            var str = "some text";
            var number = 123;

            var objects = new[] { animal, (object)str, (object)number };

            foreach (var obj in objects)
            {
                Console.Out.WriteLine("obj.GetType() = {0}", obj.GetType());
                Console.Out.WriteLine("obj.GetHashCode() = {0}", obj.GetHashCode()); ;


                Console.Out.WriteLine("obj.Equals(str) = {0}", obj.Equals(str));
                Console.Out.WriteLine("obj.Equals(number) = {0}", obj.Equals(number));
                Console.Out.WriteLine("obj.Equals(animal) = {0}", obj.Equals(animal));
                Console.Out.WriteLine("obj.ToString() = {0}\n", obj.ToString());
            }
        }

        static void Exercice_2()
        {
            var listAanimals = new List<Animal>()
            {
                new Animal("Tiger"),
                new Animal("Tiger"),
                new Animal("Tiger"),
                new Animal("Tiger"),
                new Animal("Tiger"),
                new Animal("Tiger"),
            };
        }
    }
}
