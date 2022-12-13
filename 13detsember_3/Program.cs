using System;

namespace _13detsember_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A-täht");

            int row, column;

            for (row = 0; row <= 7; row++)
            {
                for (column = 0; column <= 7; column++)
                {
                    if (((column == 1 || column == 5) && row != 0) ||
                       ((row == 0 || row == 3) && (column > 1 && column < 5)))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                    
                }
                Console.Write("\n");
            
            }
            Console.Write("\n");
        }
    }
}
