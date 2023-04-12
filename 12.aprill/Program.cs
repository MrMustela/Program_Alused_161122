namespace _12.aprill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If ja else'i kasutamine. (12.04.2023) Ises.
            
            //Teha if ja else rakendus.
            //Main meetodis on ainult if ja else.
            //Seal küsitakse, et kas soovid viktoriini mängida.
            //Kui soovid mängida, siis suunab uuele meetodile,
            //kus on küsimus.
            //Nt: Kui kõrge on Suur Munamägi.
            //Kui esimene vastus on õige, siis suunab järgmise
            //meetodi juurde ja niimoodi kokku neli korda.
            //NB! Iga küsimus on uus meetod.
            
            Console.WriteLine("Viktoriin");
            Console.WriteLine("Kas sa soovid viktoriini mängida?");
            string answer = Console.ReadLine();
            if (answer == "yes" || answer == "jah")
            {
                Console.WriteLine("Väga hea.");
                AnswerNr1();
            }
            else
            {
                Console.WriteLine("Head aega siis!");
            }
            
            static void AnswerNr1()
            {
                Console.WriteLine("Küsimus 1: Kui vana on Eesti?");
                string answer = Console.ReadLine();

                if (answer == "105")
                {
                    AnswerNr2();
                }
                else
                {
                    Console.WriteLine("Vale!");
                }
            }

            static void AnswerNr2()
            {
                Console.WriteLine("küsimus 2: Mis on Eesti pealinn?");
                string answer = Console.ReadLine();

                if (answer == "Tallinn" || answer == "tallinn")
                {
                    AnswerNr3();
                }
                else
                {
                    Console.WriteLine("Vale!");
                }
            }

            static void AnswerNr3()
            {
                Console.WriteLine("küsimus 3: Mis on Eesti rahvuskivi?");
                string answer = Console.ReadLine();

                if (answer == "paekivi" || answer == "lubjakivi")
                {
                    AnswerNr4();
                }
                else
                {
                    Console.WriteLine("Vale!");
                }               
            }

            static void AnswerNr4()
            {
                Console.WriteLine("viimane küsimus 4: Mis on Eesti suurim saar?");
                string answer = Console.ReadLine();

                if (answer == "Saaremaa" || answer == "saaremaa")
                {
                    Console.WriteLine("Palju õnne! Sa oled tõeline eestlane!");
                }
                else
                {
                    Console.WriteLine("Vale!");
                }
            }
        }
    }
}