using System;
using System.Collections.Generic;

namespace _14veebruar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cities = new Dictionary<string, string>()
            {
                {"Harju", "Tallinn" },
                {"Läänemaa", "Haapsalu" },
                {"Raplamaa", "Rapla" }
            };

            cities.Remove("Harju");

            if (cities.ContainsKey("Läänemaa"))
            {
                cities.Remove("Läänemaa");
            }

            Console.WriteLine("Total elements: {0}", cities.Count);
        }
    }
}
