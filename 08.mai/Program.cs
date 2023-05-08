namespace _08.mai
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Dictionary");
            Console.WriteLine("Loomad ja nende sugukond. (foreach)");
            Console.WriteLine("--------------");
            var animals = new Dictionary<string, string>
            {
                {"Tšintšilja", "Chinchillidae"},
                {"Ilves", "Kaslased"},
                {"Nirk", "Kärplased"},
                {"Kärp", "Kärplased"},
                {"Saarmas", "Kärplased"},
            };
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Key} {animal.Value}");
            }
            Console.WriteLine("--------------");
            Loomad();
            Console.WriteLine("--------------");
            TupleNumber();
            Console.WriteLine("--------------");
            TupleOnTuple();
            Console.WriteLine("--------------");


            //https://code-maze.com/csharp-iterate-through-dictionary/
            static void Loomad()
            {
                Console.WriteLine("\nDictionary");
                Console.WriteLine("Loomad ja nende sugukond. (forloop)");
                Console.WriteLine("--------------");
                var animals = new Dictionary<string, string>
                {
                    {"Tšintšilja", "Chinchillidae"},
                    {"Ilves", "Kaslased"},
                    {"Nirk", "Kärplased"},
                    {"Kärp", "Kärplased"},
                    {"Saarmas", "Kärplased"},
                };
                for (int number = 0; number < animals.Count; number++)
                {
                    KeyValuePair<string, string> animal = animals.ElementAt(number);
                    Console.WriteLine($"{animal.Key} {animal.Value}");
                }
            }
            //2,4 ja 5
            static void TupleNumber()
            {
                Console.WriteLine("Tuple");
                var numbers = Tuple.Create(1, 2, 3, 4, 5, 6);

                Console.WriteLine(numbers.Item2);
                Console.WriteLine(numbers.Item4);
                Console.WriteLine(numbers.Item5);
            }
            static void TupleOnTuple()
            {
                //Tuple on tuple sees,
                //kolmanda elemendi sees on uus tuple
                //peab näitama kolmanda elemendi sees
                //olevas tuples teist elementi
                var douTuple = Tuple.Create(1, 2, Tuple.Create, 8, 9, 10, 11), 12, 13);

            Console.WriteLine(List.Item3.Item2);
            }
        }
    }
}