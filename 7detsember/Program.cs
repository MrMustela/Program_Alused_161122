using System;

namespace _7detsember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ushort i = 0;
            // hakkab itereerima nii kaua kuni ushort
            // andmetüübist saadakse kätte maksimaalne arv e 63 tuhat
            // peale seda alustab uuesti
            // lõputu itereeimine tuleneb tingimuste puudumisest
            for (;;)
            {
                Console.WriteLine("i väärtus on: {0}", i );
                i++;
            }
            
        }
    }
}
