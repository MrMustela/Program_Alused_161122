namespace _10.aprill_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if ja else'i mega harjutus");

            //Teha konsoolirakendus, kus kasutate if ja else.

            //Esimene if, kus peab vastama kahele tingimusele ja
            //selleks on string "auto" ja sõna pikkus peab olema
            //neli tähemärki pikk. Kui sisestatud sõna on õige, 
            //siis kirjutab vastuse.

            //Teises tingimuses peab vastama vähemalt ühele
            //tingimusele.Tingimusi on vähemalt kaks. Tingimuseks on
            //numbri kontrollimine ja numbrid peaksid olema 4 ja 5.
            //Kui sisestatud nr on õige, siis kirjutab vastuse.

            //Kolmandas tingimuses peab olema kaks tingimust.
            //Sõna peab olema vähemalt suurem võrdne kuus tähemärki
            //ning väiksem 11 tähemärgist.Kui vastab tingimusele,
            //siis kirjutab vastuse, et sinu sisestatub nr sobib.

            //Neljanda tingmimuse sees peab vastama number 1 - le või 2 - le.
            //Selle tingimuse sees peab omakorda olema if ja else kontroll.
            //Kui nr on 1, siis kirjutab, et vastuseks nr 1 ja nr 2 puhul 2.
            
            string enter = Console.ReadLine();
            if (enter == "auto" && enter.Length == 4)
            {
                Console.WriteLine("See on auto");
            }
            else if (enter == "4" || enter == "5")
            {
                Console.WriteLine("See on: " + enter);
            }
            else if (enter.Length >= 6 && enter.Length <= 11)
            {
                Console.WriteLine("Sinu sõna on 6 ja 11 vahel" );
            }
            else if (enter == "1" || enter == "2")
            {
                if (enter == "1")
                {
                    Console.WriteLine("See on 1");
                }
                else
                    Console.WriteLine("see on 2");
            }

        }
    }
}