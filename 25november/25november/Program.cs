using System;

namespace _25november
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string a = Console.ReadLine();
            int b = 2;
            int firstA = Convert.ToInt32(a);
            

            // a == 1, a == b, a != b
            if ( firstA == 1)
            {
                Console.WriteLine("See on 1");
                
            }
            else if ( firstA == b )
            {
                Console.WriteLine("See on 2");
                
            }
            else 
            {
                Console.WriteLine("error");
                
            }
        }
    }
}
