using System;
using System.Linq;

namespace _31jaanuar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int stringRowMin = 0;
            int stringRowMax = 5;

            int[] randomAsterisk = new int[stringRowMax];

            // esimene viis
            Random asterisk = new Random();
            for (int i = stringRowMin; i < randomAsterisk.Length; i++)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("*",
                asterisk.Next(1, 20))));
            }

            Console.WriteLine("------------------------------------");
            // teine viis
            foreach (var item in randomAsterisk)
            {
                Console.WriteLine(string.Concat(Enumerable.Repeat("*",
                asterisk.Next(1, 20))));
            }
            

            
        }
    }
}
