using System;
using System.Xml.Serialization;

namespace _10jaanuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Sisesta täht ja vajuta enter!");
            string nic = "Nice";
            string notN = " Not nice";

            string ch = Console.ReadLine();
            

            switch (ch)
            {
                case "a":
                    Console.WriteLine("Vokaal a");
                    Console.WriteLine(nic);
                    break;
                   
                case "e":
                    Console.WriteLine("Vokaal e");
                    Console.WriteLine(nic);
                    break;

                case "i":
                    Console.WriteLine("Vokaal i");
                    Console.WriteLine(nic);
                    break;

                case "o":
                    Console.WriteLine("Vokaal o");
                    Console.WriteLine(nic);
                    break;


                default:
                    Console.WriteLine("Ei ole vokaal e. täishäälik");
                    Console.WriteLine(notN);
                    break;
                    
            }
        }
    }
}
