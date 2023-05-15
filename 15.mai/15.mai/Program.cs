using System.Data;
using System.IO.Pipes;

namespace _15.mai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisestage number (1-3):");

            int chose = Convert.ToInt32(Console.ReadLine());
            switch (chose)
            {
                case 1:
                    TupleSix();
                break;

                case 2:
                    TupleWithValue();
                break;

                case 3:
                    WithSortedList();
                break;
            }

            static void TupleSix()
            {
                var values = Tuple.Create(1, 2, 3, 4, 5, 6);
                TupleParam(values);
            }

            static void TupleParam(Tuple<int, int, int, int, int, int> value)
            {
                Console.WriteLine(value.ToString());
            }


            static void TupleWithValue()
            {
                ValueTuple<int, string, string> value = (1, "eesnimi", "liiknimi");
                Console.WriteLine(value.Item1);
                Console.WriteLine(value.Item2); 
                Console.WriteLine(value.Item3);
            }


            static void WithSortedList()
            {
            SortedList<int, string> datas = new SortedList<int, string>();

                datas.Add(17, "seitseteist");
                datas.Add(15, "viisteist");
                datas.Add(12, "kaksteist");
                datas.Add(21, "kakskümend üks");
                datas.Add(59, "viiskümend üheksa");
                foreach (var datass in datas)
                {
                    Console.WriteLine($"{datass.Key}, {datass.Value}");
                }


            }

        }
    }
}