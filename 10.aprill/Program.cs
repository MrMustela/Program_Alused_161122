namespace _10.aprill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //10.04.2023 kõik koodid kirjutasin mina, üritasin peast teha. Peaaegu oli mul kõik meeles, mida ma koolis õppisin.
            Console.WriteLine("If ja else'i rakendus Ises.)");
            Console.WriteLine("Sõnade kontrollimine");
            Console.WriteLine("Üks nendest tuleb sõna sisestada (hobukastan, tamm ja kask):");
            
            string enter = Console.ReadLine();
            
            if (enter == "hobukastan")
            {
                Console.WriteLine("Sa sisestasid: " + enter);
            }
            else if (enter == "kask")
            {
                Console.WriteLine("Sa sisestasid: " + enter);
            }
            else if (enter == "tamm")
            {
                Console.WriteLine("Sa sisestasid: " + enter);
            }
            else
            {
                Console.WriteLine("Error");
            }
            
        }
    }
}