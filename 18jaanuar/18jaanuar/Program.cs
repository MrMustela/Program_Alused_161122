using System;
using System.Threading;

namespace _18jaanuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta mingi nädalapäev. Näiteks mis täna on?");
            Start:
            string wD = Console.ReadLine();

            switch (wD)
            {
                case "Esmaspäev":
                case "esmaspäev":
                case "ESMASPÄEV":
                    Console.WriteLine("Täna on esmaspäev");
                break;

                case "Teisipäev":
                case "teisipäev":
                case "TEISIPÄEV":
                    Console.WriteLine("Täna on teisipäev");
                    break;

                case "Kolmapäev":
                case "kolmapäev":
                case "KOLMAPÄEV":
                    Console.WriteLine("Täna on kolmapäev");
                    break;

                case "Neljapäev":
                case "neljapäev":
                case "NELJAPÄEV":
                    Console.WriteLine("Täna on neljapäev");
                    break;

                case "Reede":
                case "reede":
                case "REEDE":
                    Console.WriteLine("Täna on reede");
                    break;

                case "Laupäev":
                case "laupäev":
                case "LAUPÄEV":
                    Console.WriteLine("Täna on laupäev");
                    break;

                case "Pühapäev":
                case "pühapäev":
                case "PÜHAPÄEV":
                    Console.WriteLine("Täna on pühapäev");
                    break;

                default:
                    Console.WriteLine("Vale! Sisesta palun uuesti.");
                    goto Start;
                    
            }
            
        }
    }
}
