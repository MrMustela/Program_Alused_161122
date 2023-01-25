using System;
using System.ComponentModel;

namespace _25jaanuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            int i, n, j, k;
            
            n = Convert.ToInt32(Console.ReadLine());

            i = 0;
            j = 1;
            Console.Write(i + " " + j);

            k = i + j;
            while (k <= n)
            {
                Console.Write($" {k}");

                i = j;
                j = k;
                k = i + j;
            }

            Console.ReadKey();
        }
    }
}
