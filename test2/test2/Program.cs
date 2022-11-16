using System;
using System.Threading.Tasks.Dataflow;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite number. 1 to 100.");
            string number = Console.ReadLine();

            int numberParsed = Int16.Parse(number);

            // saab ka panna Console.WriteLine(Convert.ToInt(number));


            // if ja else'i lisamine
            // kui alla 50, siis tuleb vastus. 

            Console.ReadKey();

            if ( numberParsed >= 1 && numberParsed <= 100)

            {
                Console.WriteLine("Your favorite number is " + number );


            }
            else if ( numberParsed <= 0 && numberParsed > 101 ) 
            {
                Console.WriteLine("ERROR! Only 1 to 100 numbers are allowed!");
            }
            
        
        }
    }
}
