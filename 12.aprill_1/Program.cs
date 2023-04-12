namespace _12.aprill_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja else rakendus");
            Console.WriteLine("Numbride suurendamine");
            int number = 1;
            string choice = Console.ReadLine(); ;


            for (int i = 100; i > number; number++)
            if (number < 11)
            {               
                Console.WriteLine(number);

            }
            Console.WriteLine("-----------------");
            int number2 = 0;
            for (int i = 20; i > number2; i--)
            if (i > 4)
            {
                    Console.WriteLine(i);
            }
            Console.WriteLine("-----------------");

            //neljas if
            //bitwise operator
            if (choice == "1")
            {
                uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
                Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");
                
                Console.WriteLine("-----------------");
                
                //operaator << tähendab, et mingi väärtus on palju väiksem väärtust kui mingi muu väärtus, nt a << b.
                uint y = x << 4;
                Console.WriteLine($"After: {Convert.ToString(y, toBase: 2)}");

            }
        }
    }
}