using System;
using System.Collections.Generic;

namespace _13veebruar_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new List<List<string>>
           {
               new List<string> {"tea", "road", "car", "sky"},
               new List<string> {"cup", "falcon", "loan", "airplane"},
               new List<string> {"head", "snow", "frost", "fish"}

           };

            foreach (var nested in words)
            {
                foreach (var word in nested)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
