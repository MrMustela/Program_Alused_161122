using System;
using System.Collections.Generic;
using System.Linq;

namespace _14veebruar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var domain = new Dictionary<string, string>()
            {
                {"est", "Estonia"},
                {"lat", "Latvia"},
                {"fin", "Finland"},
                {"swe", "Sweden"},
            };
            
            //esimene lihtne variant
            foreach (var pair in domain)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            
            //on ka teine viis, kuid raskem.
            //domain.ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Value}")); 
        }
    }
}
