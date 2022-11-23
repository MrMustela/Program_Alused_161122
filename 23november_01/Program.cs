using System;

namespace _23november_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta nimi");
            string nimi = Console.ReadLine();

            Console.WriteLine("Tere, " + nimi + ".");
            

            Console.WriteLine("Mis on sinu vanus?");
            
            string vanus = Console.ReadLine();
            int firstvanus = Convert.ToInt16(vanus);

            Console.ForegroundColor = ConsoleColor.Green;
   
            Console.WriteLine("Sinu vanus on " + firstvanus + ", " + nimi + ".");
                


            
            








        }

    }
}
