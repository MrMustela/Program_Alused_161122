using System;
using System.Collections.Generic;

namespace _14veebruar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<int, string>
            {
                {1, "Estonia"},
                {2, "Latvia"},
                {3, "Lithuania"},
            };
            
            //result.ToList().ForEach(x => Console.WriteLine($"{x.Key} - {x.Value}"));

            foreach (var pair in result)
            {
               Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}
