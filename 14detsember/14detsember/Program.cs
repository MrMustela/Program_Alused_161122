using System;
using System.Security.Cryptography;

namespace _14detsember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Start:

            Console.Title = "Kuju valimine ja arvutamine";

            Console.WriteLine("\n1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");

            string shape = Console.ReadLine();

            switch (shape)
            {
                case "ruut":
                    
                    Quadrilateral();
                    break;
                
                case "teemant":
                    
                    Diamond();
                    break;

                case "ristkülik":

                    Rectangle();
                    break;

                case "kolmnurk":
                    
                    Triangle();
                    break;

                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }
            //Console.ReadKey();
            //goto Start;
        }

        private static void Quadrilateral()
        {
            Console.WriteLine("\nSisesta ruudu ühe külje mõõtühik sentimeetrites.");
            double quadrilateral = double.Parse(Console.ReadLine());

            for (int row = 1; row <= quadrilateral; row++)
            {
                for (int column = 1; column <= quadrilateral; column++)
                {
                    string mark;
                    if (row == column || row + column <= row + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Diamond()
        {
            Console.WriteLine("\nSisesta teemanti raadiuse mõõtühik sentimeetrites");
            double diamond = double.Parse(Console.ReadLine());


            double count = 10;

            for (int k = 1; k <= diamond; k++)
            {
                for (int i = 0; i <= count; i++)
                {
                    Console.Write(" ");
                    count--;
                }

                for (int i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            count = 1;
            for (int k = 1; k <= diamond - 1; k++)
            {
                for (int i = 1; i <= diamond; i++)
                {
                    Console.Write(" ");
                    count++;
                }
                for (int i = 1; i <= 2 * (diamond - k) - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void Rectangle()
        {
            Console.WriteLine("\nSisesta ristküliku kahe külje mõõtühik sentimeetrites");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            for (int row = 1; row <= a; row++)
            {
                for (int column = 1; column <= b; column++)
                {
                    string mark;
                    if (row == column || row + column <= +1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }

        private static void Triangle()
        {
            Console.WriteLine("\nSisesta võrdkülgse kolmnurga külje pikkus sentimeetrites");

            double length = double.Parse(Console.ReadLine());
           
            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length * 2 - 1; column++)
                {
                    string mark = "";

                    if (row == length)
                    {
                        mark = "*";
                    }
                    else if(row + column >= length + 1 && column - length + 1 <= row)
                    {
                        mark= "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}
