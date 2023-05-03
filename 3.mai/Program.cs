namespace _3.mai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vali:");
            Console.WriteLine("1. String list");
            Console.WriteLine("2. Break list ");
            Console.WriteLine("3. Continue list");
            Console.WriteLine("4. Dictionary list");
            string rida = "---------------";
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine(rida);
                StringList();
            }
            if (choice == 2)
            {
                Console.WriteLine(rida);
                NameList();
            }
            if (choice == 3)
            {
                Console.WriteLine(rida);
                ContinueList();
            }
            if (choice == 4)
            {
                Console.WriteLine(rida);
                DictionaryList();
            }
            if (choice == 21)
            {
                Console.WriteLine(rida);
                NumberList();
            }
            if (choice == 42)
            {
                Console.WriteLine(rida);
                NrFour();
            }


            static void StringList()
            {
                List<string> stringList = new List<string>()
            { "A", "B", "C", "D", "E"};
                foreach (var alphabets in stringList)
                {
                    Console.Write(alphabets + " ");
                }
            }

            static void NameList()
            {
                var names = new List<string>()
                { "Veiko", "Eleri", "Taavet", "Reino", "Ranno", "Robert" };
                foreach (var name in names)
                {
                    if (name == "Taavet")
                    {
                        break;
                    }
                    Console.WriteLine(name);
                }
            }

            static void ContinueList()
            {
                var numbers = new List<string>()
                { "One", "Two", "Three", "Four", "Five"};
                foreach (var numContinue in numbers)
                {
                    if (numContinue == "Three")
                    {
                        continue;
                    }
                    Console.WriteLine(numContinue);
                }
            }

            static void DictionaryList()
            {
                var data = new Dictionary<int, string>
                {
                    {2,".mai : automaks"},
                    {24,".veebruar : Eesti vabariigi aastapäev"},
                    {15,".juuni : sünnipäev"},
                    {3,".mai : kolmapäev"}
                };

                foreach (var datas in data)
                {
                    Console.WriteLine($"{datas.Key} {datas.Value}");
                }
            }

            static void NumberList()
            {

                Console.WriteLine("!Special! Vali number (1-10):");
                int num = Convert.ToInt32(Console.ReadLine());
                
                var numbers = new List<int>()
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                    if (number == num)
                    {
                        break;
                    }
                }
            }
            static void NrFour()
            {
                Console.WriteLine("!Special!");
            }

            //Console.WriteLine("\n-------------------");
            //int-iga
            //List<int> stringList2 = new List<int>()
            //    { 1, 2, 3, 4, 5};
            //foreach (var numbers in stringList2)
            //{
            //    Console.Write(numbers + " ");
            //}

        }
    }
}