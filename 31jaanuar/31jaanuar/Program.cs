using System;

namespace _31jaanuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            string sentence = "Euroopa üks pealinnadest on: ";

            var cities = Tuple.Create("Tallinn", "Riga", "Vilnius",
                "Helsinki", "Stockholm", "Pariis", "Oslo", "Berliin");
            Console.WriteLine(sentence + cities.Item1);
            Console.WriteLine("-------------------------------");
            
            string[] city = {"Tallinn", "Riga", "Vilnius",
                "Helsinki", "Stockholm", "Pariis", "Oslo", "Berliin" };
            for (int i = 0; i < city.Length; i++)
            {
                Console.WriteLine(sentence + city[i]);
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine(sentence + city[2]);
            Console.WriteLine("-------------------------------");

            // muutuja nimega number on nüüd suvaline number
            Random number = new Random();
            // muutuja randomNumber annab vahemikus 0 kuni 4 väärtusega tulemusi
            int randomNumber = number.Next(0, 4);
            // nüüd saame tulemusi suvaliselt 
            Console.WriteLine(sentence + city[randomNumber]);
        }
    }
}
