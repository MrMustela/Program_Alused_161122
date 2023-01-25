using System;

namespace _25jaanuar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta number: ");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;

            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= n)
                {
                    Console.Write(j + " ");
                    j++;
                }
                i++;
            }
           

            Console.WriteLine("\n\n\nKolmnurk ");

            n = Convert.ToInt32(Console.ReadLine());
            i = 1;

            while (i <= n)
            {
                Console.WriteLine();
                int j = 1;
                while (j <= i)
                {
                    Console.Write(j + " ");
                    j++;
                }
                i++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
