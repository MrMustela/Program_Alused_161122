using System;
using System.Collections.Generic;

namespace _14veebruar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var states = new Dictionary<string, string>();

            states.Add("Estonia", "EST");
            states.Add("Latvia", "LAT");
            states.Add("Finland", "FIN");
            states.Add("Sweden", "SWE");

            foreach (var state in states)
            {
                Console.WriteLine($"{state.Key} - {state.Value}");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine(states["Estonia"]);
            Console.WriteLine(states["Latvia"]);
            Console.WriteLine(states["Finland"]);
            Console.WriteLine("------------------------------");
            if (states.ContainsKey("Estonia"))
            {
                Console.WriteLine(states["Estonia"]);
            }
            else
            {
                Console.WriteLine("Nimega Estonia ei eksisteeri");
            }
        }
    }
}
