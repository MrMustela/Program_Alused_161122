using System;

namespace _25jaanuar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = 1;
            while (a <= 5)
            {
                int b = 1;
                while (b <= 5)
                {
                    Console.Write(b + " ");
                    b++;
                }
                Console.WriteLine();
                a++;
            }

            Console.ReadKey();
        }
    }
}
