using System;

namespace real11jaanuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta number 1 kuni 3.");
           
            double greeting = Convert.ToDouble(Console.ReadLine()); 
            double greeting2 = Convert.ToDouble(greeting);
            //float greeting = 1.2F;
            switch (greeting2)
            {
                case 1:
                    Console.WriteLine("Hello");
                    goto case 2;
                    
                case 2:
                    Console.WriteLine("Bonjour");
                    goto case 3;

                case 3:
                    Console.WriteLine("Namaste");
                    goto default;

                default:
                    Console.WriteLine("Entered value is: " + greeting2);
                    break;
            }
        }
    }
}
