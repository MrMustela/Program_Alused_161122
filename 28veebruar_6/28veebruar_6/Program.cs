using System;

namespace _28veebruar_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enum");
            // teha enum majatüüpidest ja kutsuda neid Main meetodis esile

            Console.WriteLine();
            //näitab muutuja vastust
            Console.WriteLine(houseTypes.Singlefamily);
            Console.WriteLine("-------------------------------------");
            //mingi antud muutuja väärtus näitab kindla muutuja vastust
            var ht = (houseTypes)1;
            Console.WriteLine(ht);
            Console.WriteLine("-------------------------------------");
            //muutuja muutub teatud tüüpi väärtuseks
            int house = (int)houseTypes.Multifamily;
            Console.WriteLine(house);
        }

        enum houseTypes
        {
            Singlefamily,
            Townhouse,
            Multifamily,
            Modularhome,
            Penthouse // = 1

        }
    }
}
