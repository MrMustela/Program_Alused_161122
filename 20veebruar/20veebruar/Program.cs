using System;
using System.Collections.Generic;

namespace _20veebruar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var street = new Dictionary<string, string>
            {
                {"Ristiku", "tänav" },
                {"Tuulemaa", "tänav" },
                {"Puhangu", "tänav" }
            };

            foreach (var paar in street)
            {
                Console.WriteLine($"{paar.Key} {paar.Value}");
            }

        }
    }
}
