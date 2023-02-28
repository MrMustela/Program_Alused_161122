using System;
using System.Drawing;

namespace _28veebruar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");

            //
            //NB! 
            HouseParameters point = new HouseParameters(5, 10, 6, "Peeter");

            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);
            Console.WriteLine(point.Q);
            Console.WriteLine(point.Name);

        }
        struct HouseParameters
        {
            public int X;
            public int Y;
            public int Q;
            public string Name;
            
            //teha siia konstruktor
            public HouseParameters(int x, int y, int q, string name)
            {
                // võib kasutada ka this muutuja ees
                this.X = x;
                this.Y = y;
                this.Q = q;
                this.Name = name;
            }
        }

       

      
        

        


    }
}
