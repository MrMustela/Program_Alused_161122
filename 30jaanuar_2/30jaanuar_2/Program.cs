using System;

namespace _30jaanuar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array");

            //muutuja nimega array sisse paneme mitu
            //väärtust numbritega 10, 20, 30, 40 ja 50
            //mitu muutujat saab panna, kui
            //andmetüübi järele paned märgid []

            int[] array = { 10, 20, 30, 40, 50 };
            
            //siin kuvatakse kõik need numbrid 
            //kindlasti peab panema muutuja järele .Length
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
