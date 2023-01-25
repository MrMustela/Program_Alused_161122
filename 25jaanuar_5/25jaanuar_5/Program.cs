using System;

namespace _25jaanuar_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While kodutöö, sellest programmist teha vooskeem");
            Console.WriteLine("NB! Vooskeem teha .html faililaiendina ja saata emaili.");
            int number = 1;

            do
            {
                Console.Write($"{number} ");
                number++;
            } while (number <= 5);
        }
    }
}
