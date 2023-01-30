using System;

namespace _30jaanuar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array 4");
            
            int[] array = new int[10];
            int i;

            Console.Write("Loe ja prindi massiiv");

            Console.WriteLine("Kokku on 10 elementi");

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("element - {0} :", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elemendid massiivis on: ");

            for (i = 0; i < 10; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write("\n");
        }
    }
}
