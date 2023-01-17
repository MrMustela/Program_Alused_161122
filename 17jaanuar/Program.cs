using System;

namespace _17jaanuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                Console.WriteLine("This is number " + number);
                break;

                case 2:
                Console.WriteLine("This is number " + number);
                break;

                case 3:
                Console.WriteLine("This is number " + number);
                break;

                default:
                Console.WriteLine("Error");
                break;

            }
            
        
        }

           
    }
}
