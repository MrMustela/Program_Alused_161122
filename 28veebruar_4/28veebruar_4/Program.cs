using System;

namespace _28veebruar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct - cars");

            //Structi välja kutsumine
            Cars cars = new Cars();
            //Structi sees oleva meetodi välja kutsumine
            cars.Engine();

            Console.WriteLine(cars.x);
            Console.WriteLine(cars.y);

            Cars cars2 = Cars.Getengines();
            //Kõik väärtused on nullid, sest nendele pole väärtus määratud
            Console.WriteLine(cars2.x);
            Console.WriteLine(cars2.y);

        }

        struct Cars
        {
            public int x { get; set; }
            public int y { get; set; }

            //Structi sisse tuleb meetod
            public void Engine()
            {
                x = 5;
                y = 10;
            }
            //Structis on staatiline meetod
            public static Cars Getengines()
            {
                return new Cars();
            }
        }
    }
}
