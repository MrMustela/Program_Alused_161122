using System;

namespace _13detsember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i, j, rows;
            
            Console.WriteLine("Sisesta ridade number");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                   
                    Console.Write(i);
               
                }
                Console.Write("\n");
            }

            
        }
    }
}
