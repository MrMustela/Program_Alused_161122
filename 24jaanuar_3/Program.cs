using System;

namespace _24jaanuar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While 3");

            int i = 0, j = 1;

            while (i < 2)
            {
                Console.WriteLine("i = {0}", i);
                i++;

                while (j <= 2)
                {
                    Console.WriteLine("j = {0}", j);
                    j++;
                }
            }
        }
    }
}
