using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _31jaanuar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 10, 15, 16, 8, 6 };
            //int amount = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
            //Console.WriteLine(numbrite max);
            //Console.WriteLine(numbrite min);
            //Console.WriteLine(numbrite summa);
            //Console.WriteLine(numbrite keskmine väärtus);

            //Minu viisi eelistus hetkel selle all 
            
            //Console.WriteLine("Maksimum number on: " + numbers[2]);
            //Console.WriteLine("Miinimum number on " + numbers[4]);
            //Console.WriteLine("Summa on " + amount);
            //Console.WriteLine("Keskmine väärtus on " + amount / 5);

            //Parim ja lihtne viis selle all

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
        }
    }
}
