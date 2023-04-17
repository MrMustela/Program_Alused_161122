﻿using System.Security.Cryptography.X509Certificates;

namespace _17.aprill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali mingi juhtum. Tuleb sisesta numbrit (1-4):");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Liitmine");
                    Console.WriteLine("Sisesta esimene number:");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Sisesta teine number:");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    int answer = number1 + number2;
                    Console.WriteLine("Vastus on: " + answer);
                    break;

                case 2:
                    Kool();
                    break;

                case 3:
                    Beep();
                    break;

                case 4:
                    //@ ei ole vist oluline
                    Console.WriteLine("Faili tegemine õnnestus");
                    string file = @"C:/Users/Opilane/Desktop/Fail.txt";
                    File.Create(file);
                    
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            
            static void Kool()
            {
                Console.WriteLine("Oled käinud koolis?");
                Console.WriteLine("Olen käinud koolis");
            }
            
            static void Beep()
            {
                Console.WriteLine("Beep");
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }

        }
    }
}