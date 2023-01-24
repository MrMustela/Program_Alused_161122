using System;

namespace _24jaanuar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While loop");

            int i = 1, n = 5, result;

            do
            {
                result = n * i;
                Console.WriteLine("{0} * {1} = {2}", n, i, result);
                i++;
            } while (i <= 10);
        }
    }
}
