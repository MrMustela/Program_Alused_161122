using System;

namespace _31jaanuar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 15, 16, 8, 6 };
            
            Console.WriteLine("---------------");
            Console.WriteLine("õige järjestusega massiiv");
            foreach (var element in numbers)
            {
                Console.WriteLine(element);
            }
           
            Console.WriteLine("---------------");
            Console.WriteLine("Alates väiksemast kuni suuremani");
            Array.Sort(numbers);

            foreach (var element in numbers)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("---------------");
            Array.Reverse(numbers);
            Console.WriteLine("tagurpidi numbrite jada");
            Array.ForEach<int>(numbers, n => Console.WriteLine(n));

            Console.WriteLine(Array.BinarySearch(numbers, 15));
        }
    }
}
