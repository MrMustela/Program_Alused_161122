using System;

namespace _28veebruar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");

            //meetodi välja kutsumine
            Coordinate coordinate = new Coordinate();

            Console.WriteLine(coordinate.x);
            Console.WriteLine(coordinate.y);

        }
    }

    struct Coordinate
    {
        public int y;
        public int x;
    }
}
