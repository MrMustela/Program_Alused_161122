using System;
using System.Linq;

namespace _31jaanuar_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "cat", "alligator", "fox", "donkey", "bear", "elephant", "goat", "rabbit", "chinchilla", "rat", "giraffe", "zebra", "mouse", "dog" };

            //Array.Sort(animals);

            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}
            Console.WriteLine("--------------------------");
            //järjestab kolm esimest sõna (elementi)
            //tähestikulises järjestuses
            Array.Sort(animals, 0, 3);

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("------------------------");
            int[] numbers = { 1, 2, 3, 4, 3, 55, 23, 2 };
            Array.Sort(numbers);
            //funktsioon nimega distinct välistab kordused
            int[] distinct = numbers.Distinct().ToArray();

            foreach (var dist in distinct)
            {
                Console.WriteLine(dist);
            }



        }
    }
}
