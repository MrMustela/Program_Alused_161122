using System;

namespace _20veebruar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tuple");

            var person = Tuple.Create(1, "Jaanus", "Tartu");
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);

            Console.WriteLine("--------------------------------------");
            
            var numbers = Tuple.Create("One", 2, 3, 4, "viis", "six", "seven", 8);
            Console.WriteLine(numbers.Item1);
            Console.WriteLine(numbers.Item2);
            Console.WriteLine(numbers.Item3);
            Console.WriteLine(numbers.Item4);
            Console.WriteLine(numbers.Item5);
            Console.WriteLine(numbers.Item6);
            Console.WriteLine(numbers.Item7);
            Console.WriteLine(numbers.Rest);
            Console.WriteLine(numbers.Rest.Item1);

            Console.WriteLine("--------------------------------------");
            var nestedNumbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13, Tuple.Create(14, 15, 16, 17)));
            Console.WriteLine(nestedNumbers.Item1);
            Console.WriteLine(nestedNumbers.Item7);
            Console.WriteLine(nestedNumbers.Rest.Item1);
            Console.WriteLine(nestedNumbers.Rest.Item1.Item1);
            Console.WriteLine(nestedNumbers.Rest.Item1.Item2);
            Console.WriteLine(nestedNumbers.Rest.Item1.Item3);
            Console.WriteLine(nestedNumbers.Rest.Item1.Item4);

            Console.WriteLine("--------------------------------------");
            var numbrid = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
            Console.WriteLine(numbrid.Item1);
            Console.WriteLine(numbrid.Item2);
            Console.WriteLine(numbrid.Item3);
            Console.WriteLine(numbrid.Item3.Item1);
            Console.WriteLine(numbrid.Item4);
            Console.WriteLine(numbrid.Rest.Item1);

            Console.WriteLine("--------------------------------------");
            var inimene = Tuple.Create(1, "Steve", "Gates");
            DisplayTuple(inimene);

            Console.WriteLine("--------------------------------------");
            var humans = GetHumans();
            {

            }
              
            



        }

        static void DisplayTuple(Tuple<int, string, string> person)
        {
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);

        }

        static Tuple<int,string,string> GetHumans()
        {
            return Tuple.Create(1, "Bill", "Jobs");
        }
    }
}
