using System;

namespace _30jaanuar_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array 6");

            string[] genders = {"m", "f", "m", "m", "m", "f"
            , "f", "f", "m", "m", "f"};

            int female = 0, male = 0;

            foreach (var gender in genders)
            {
                if (gender == "f")
                {
                    female++;
                }
                else
                {
                    male++;
                }
                // teine viis, seda nimetatakse lühikeseks if'ks ja else-ks
                // var result = gender == "f" ? female++ : male++;
            }

            Console.WriteLine("Nr of female {0}", female);
            Console.WriteLine("Nr of male {0}", male);
        }
    }
}
