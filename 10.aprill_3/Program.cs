using System.Security.Cryptography.X509Certificates;

namespace _10.aprill_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if ja else harjutus 2");
            //Teha if ja else rakendus.
            //Kokku on neli if ja else.Kui on valitud mingi variant,
            //siis if ja else sees on olemas meetodi nimi.
            //Iga meetod teeb midagi ja selle sisu saate ise välja mõelda.
            //Nt: Selle meetodi sees võidakse küsida uusi andmeid või
            //toimub arvutamine.
            
            string enter = Console.ReadLine();

            if (enter == "1")
            {
                static void M1()
                {
                    Console.WriteLine("Mis on 1 + 2?");
                    string answer = Console.ReadLine();
                    if (answer == "3")
                    {
                        Console.WriteLine("Õige!");
                    }
                    else
                        Console.WriteLine("Vale!");
                }
                M1();
            }
            else if (enter == "2")
            {
                static void M2()
                {
                    Console.WriteLine("Mis on 5 + 5?");
                    string answer = Console.ReadLine();
                    if (answer == "10")
                }
                M2();

            }
            else if (enter == "3")
            {
                static void M3()
                {
                    Console.WriteLine("ok");
                }
                M3();

            }
            else if (enter == "4")
            {
                static void M4()
                {
                    Console.WriteLine("ok");
                }
                M4();

            }


        }

    }
}