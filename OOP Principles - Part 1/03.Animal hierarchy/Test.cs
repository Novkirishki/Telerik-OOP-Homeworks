//Problem 3. Animal hierarchy
//Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors
//and methods. Dogs, frogs and cats are Animals. All animals can produce sound 
//(specified by the ISound interface). Kittens and tomcats are cats. 
//All animals are described by age, name and sex. Kittens can be only female and
//tomcats can be only male. Each animal produces a specific sound.
//Create arrays of different kinds of animals and calculate the average age 
//of each kind of animal using a static method (you may use LINQ).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Animal_hierarchy
{
    class Test
    {
        static void AverageAge(Animal[] animals)
        {
            double age = 0;
            int count = 0;
            var groups = from animal in animals
                         group animal by animal.GetType() into animalGr
                         select animalGr;
            foreach (var group in groups)
            {
                foreach (var animal in group)
                {
                    if (count == 0)
                    {
                        Console.Write("Average age of {0}s in array is:", animal.GetType().Name);
                    }
                    age += animal.Age;
                    ++count;
                }
                Console.WriteLine(age / count);
                age = 0;
                count = 0;
            }
        }
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[] 
            {
                new Dog("Sharo", 5, Sex.male),
                new Dog("Bella", 2, Sex.female),
                new Frog("Kvaki", 1, Sex.male),
                new Cat("Pisana", 6, Sex.female),
                new Kitten("Penka", 1),
                new Tomcat("Tom", 8),
                new Tomcat("Leo", 5)
            };

            AverageAge(animals);

            foreach (var animal in animals)
            {
                animal.produceSound();
            }
        }
    }
}
