using System;

namespace _25november_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta hinde number: ");
            // muudab string andmetüübi int andmetüübiks
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 || num >= 101)
            {
                Console.WriteLine("Vale number");
            }
           
            else if (num >= 50 && num < 60)
            {
                Console.WriteLine("Failer oled");
            }
           
            else if (num >= 60 && num < 70)
            {
                Console.WriteLine("D hinde saad");
            }
           
            else if (num >= 80 && num < 90)
            {
                Console.WriteLine("B hinde saad");
            }
            
            else if (num >= 90 && num < 100)
            {
                Console.WriteLine("A hinde saad");
            }

            else
            {
                Console.WriteLine("noh jah siis.");
            }
        }
    }
}
