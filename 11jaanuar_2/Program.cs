using System;
using System.Threading;

namespace _11jaanuar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start:

            Console.WriteLine("Täringu viskamine");

            int cube = new Random().Next(1, 7);

            

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Said 1 ja oled luuser");
                    break;
                    
                case 2:
                    Console.WriteLine("Said 2, said natuke parema tulemuse");
                    break;

                case 3:
                    Console.WriteLine("Said 3, pole paha");
                    break;

                case 4:
                    Console.WriteLine("Said 4, juba hakkab tulema");
                    break;

                case 5:
                    Console.WriteLine("Said 5, oled tubli ");
                    break;

                case 6:
                    Console.WriteLine("Said 6, 100%! Epic win!");
                    break;

                    default:
                    Console.WriteLine("ERROR");
                    break;





            }
            Console.ReadLine();

            //goto Start;
        }
    }
}
