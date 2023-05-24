using System.Text.RegularExpressions;

namespace _24.mai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("True regex");
            string word = "#CD5C5C";
            Console.WriteLine("Hex code: " + word);
            Console.WriteLine("Kas on regex: " + TrueHex(word));

            //teha uus rida, kus regex vastab false'ile (ises.)
            Console.WriteLine("False regex");
            string word2 = "#CD5C5C";
            Console.WriteLine("Hex code: " + word2);
            if (FalseHex(word2) == true)
            {
                Console.WriteLine("Kas on regex: False");
            }
            else
            {
                Console.WriteLine("Kas on regex: True");
            }

        }
        public static bool TrueHex(string word)
        {
            return Regex.IsMatch(word, @"[#][0-9A-Fa-f]{6}\b");
        }

        public static bool FalseHex(string word2)
        {
            return Regex.IsMatch(word2, @"[#][0-9A-Fa-f]{6}\b");
        }

    }
}