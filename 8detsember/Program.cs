using System;

namespace _8detsember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            
            Console.WriteLine("Display the sum on odd number: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta number");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("The usual number are: ");

            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2*i-2);
                sum += 2 * i - 2;
            }
            Console.Write(" The sum on odd natural number up to {0} terms: {1} \n ", n, sum);
        }
    }
}
