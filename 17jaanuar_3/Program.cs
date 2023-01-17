using System;

namespace _17jaanuar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 125;
            Console.WriteLine("Numbrite tulemus");
            // Kuidas % operaator toimib: kui x on 125 ja operaatorile on nt antud 2 väärtust,
            // siis 125:2= 62,5; 62 * 2 = 124; 125-124 = 1;
            // 1 on meie jäägi arv järelikult on tegu paaritu arvuga.
            // Kui x on 124; 124-124 = 0; siis jäägi arv puudub, järelikult on tegu paarisarvuga.
            switch ( x % 2)
            {
                case 0:
                    Console.WriteLine($"{x} on paarisarv");
                    break;
                case 1:
                    Console.WriteLine($"{x} on paaritu arv");
                    break;
                        
            }
        }
    }
}
