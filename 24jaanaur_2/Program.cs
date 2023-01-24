using System;
using System.Threading;

namespace _24jaanaur_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While2");

            int i = 0;

            while(true)
            {
                Console.WriteLine("i = {0}", i);
                i++;

                if (i > 10)
                {
                    break;
                }
            }
        }
    }
}
