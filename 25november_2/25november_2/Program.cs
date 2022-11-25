using System;

namespace _25november_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja else'i nestimine.");

            int a = -1;
            int b = 10;
            int c;

            //a on väiksem, kui 0 ja b on väiksem, kui 0
            //&& - tähendab ja-d ning antud juhul peab mõlemale tingimusele vastama
            if (a < 0 && b < 0)
            {
                Console.WriteLine("Mõlemad on negatiivsed numbrid.");
            }
            // || - tähendab or (või) operaatorit.
            // Võib olla ainult ühele tingimusele vastata sulgude sees
            else if (a < 0 || b < 0)
            {
                if (b > 0 && b <= 10)
                {
                    c = a + b;
                    Console.WriteLine("Tulemus: {0}", c);
                }
                Console.WriteLine("üks number on negatiivne");

            }
            else
            {
                Console.WriteLine("Mõlemad numbrid on positiivsed");
            }
            Console.ReadLine();
        }
    }
}
