using System;
using System.Collections;
using System.Collections.Generic;

namespace _27veebruar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List");

            System.Collections.Generic.SortedList<int, string> numberNames = new System.Collections.Generic.SortedList<int, string>();

            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            foreach (var kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("-------------------------------------------");
            System.Collections.Generic.SortedList<string, string> cities = new System.Collections.Generic.SortedList<string, string>()
            {
                {"Tallinn", "EST" },
                {"Helsinki", "FIN" },
                {"Riga", "LAT" },
                {"Stockholm", "SWE" },
            };

            foreach (var kvp in cities)
            {
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);

            }
            
            Console.WriteLine("-------------------------------------------");
            System.Collections.Generic.SortedList<int, string> numbers = new System.Collections.Generic.SortedList<int, string>()
            {
                {3, "Three"},
                {5, "Five"},
                {1, "One"},
            };

            Console.WriteLine("Esialgsed võtmeväärtused");

            foreach (KeyValuePair<int, string> kvp in numbers)
            {
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
            }

            numbers.Add(6, "Six");
            numbers.Add(2, "Two");
            numbers.Add(4, "Four");

            Console.WriteLine("Lisasime uusi numbreid");


            foreach (KeyValuePair<int, string> kvp in numbers)
            {
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
            }


            Console.WriteLine("-------------------------------------------");

            System.Collections.Generic.SortedList<int, string> addNumbers = new System.Collections.Generic.SortedList<int, string>()
            {
                {3, "Three" },
                {1, "One" },
                {2, "Two" },
            };
            addNumbers[2] = "TWO"; //asendame Two asemel TWO
            addNumbers[4] = "Four"; //lisasime uue väärtuse

            foreach (var kvp in addNumbers)
            {
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
            }

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Kasutame if-i");

            if (!addNumbers.ContainsKey(4))
            {
                addNumbers[4] = "Four";
            }

            string result;

            if (addNumbers.TryGetValue(4, out result))
            {
                Console.WriteLine("Key: {0}, Value: {1}", 4, result);
            }
            Console.WriteLine("-------------------------------------------");
            System.Collections.Generic.SortedList<int, string> keyValuePairs = new System.Collections.Generic.SortedList<int, string>()
            {
                {3, "Three" },
                {1, "One" },
                {2, "Two" },
                {5, "Five" },
                {4, "Four" },
            };

            keyValuePairs.Remove(1); //eemaldab seda väärtust
            keyValuePairs.Remove(10);

            keyValuePairs.RemoveAt(0); //eemaldab 

            foreach (var kvp in keyValuePairs)
            {
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
            }

        }
    }
}
