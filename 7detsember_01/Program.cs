using System;

namespace _7detsember_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int i = 0;

            for (;;)
            {
                if (i < 10)
                {
                    Console.WriteLine("i väärtus on: {0}", i);
                    i++;
                }
                else
                {
                    break;
                }
            }

        }
    }
}
