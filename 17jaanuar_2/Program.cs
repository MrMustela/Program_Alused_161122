using System;

namespace _17jaanuar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta hinne");

            string mark = Console.ReadLine();
            int number = Convert.ToInt32(Console.ReadLine());
            
            switch (mark)
            {
                case "A":
                
                    Console.WriteLine("Suurepärane töö!");
                    break;

                case "B":
                case "C":
                    Console.WriteLine("Hea töö");
                    break;

                case "D":
                    Console.WriteLine("Said läbi");
                    break;

                case "F":
                    Console.WriteLine("Failer oled");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
