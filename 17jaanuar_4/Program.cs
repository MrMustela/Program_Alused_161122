using System;
using System.IO;

namespace _17jaanuar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Te saate sisestada 4 asja, kas sisestad if.else, ternary, switch või üllatus!");

            string text = Console.ReadLine();
            
            switch (text)
            {
                case "if.else":
                Console.WriteLine("See on " + text);
                    break;

                case "ternary":
                    Console.WriteLine("See on " + text);
                    break;

                case "switch":
                    Console.WriteLine("see on " + text);
                    break;

                case "üllatus":
                    Console.WriteLine("See ongi " + text);
                    break;

                default:
                    Console.WriteLine("Error");
                    break;

            }

                


        }
    }
}
