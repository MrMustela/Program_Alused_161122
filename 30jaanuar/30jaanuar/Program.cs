using System;

namespace _30jaanuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array e jada e massiiv");

            //loome massiivi
            int[] array = new int[10];

            array[0] = 10; //massiivi kasutamine
            array[2] = 20;
            array[4] = 30;

            //massiiv käib kõik numbrid läbi
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
