using System;

namespace _28veebruar_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum");

            //enumi esile kutsumine
            Console.WriteLine(Weekdays.Friday);

            //saame teada, mis numbrilise väärtusega on reede ja vastus on 4
            int day = (int)Weekdays.Monday;
            Console.WriteLine(day);

            //teine variant, et kuidas saada näidata päeva nimetust
            var wd = (Weekdays)5;
            Console.WriteLine(wd);
        }


        enum Weekdays
        {
            //enum on numereerija
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,

        }
    }
}
