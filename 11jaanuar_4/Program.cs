using System;

namespace _11jaanuar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suvalised värvid");

            Color c = (Color)new Random().Next(0, 5);

            switch (c)
            {
                case Color.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine("Punane");
                    break;

                case Color.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    Console.WriteLine("Roheline");
                    break;

                case Color.Blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    Console.WriteLine("Sinine");
                    break;

                case Color.White:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Valge");
                    break;

                case Color.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.WriteLine("Kollane");
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }
        }




        public enum Color
        {
            Red,
            Green,
            Blue,
            White,
            Yellow    
        }
    }
}
