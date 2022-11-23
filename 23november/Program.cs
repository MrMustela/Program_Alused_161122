using System;
using System.Xml.Serialization;

namespace _23november
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kui kaugel sa elad? (kilomeetrites)");
            
            string kaugus = Console.ReadLine();
            int kaugusParse = Int16.Parse(kaugus);
            
            // teha if ja else-ga konsooli aplikatsioon. Pead saama sisestada kaugust km-string.
            // Esimese if püüab koodi kinni 0km kuni 10km, teine 11km kuni 30km, kolmas 31km kuni 50km,
            // neljas 51km kuni 90km, viies 91km. Vastuse saab ise välja mõelda.
            
            if (kaugusParse >= 0 && kaugusParse <= 10)
            {
                Console.WriteLine("Sa elad vist linnas. Linna elu pole viga, kuid lihtne on küll kindlasti elada. ");
            }
            else if (kaugusParse >= 11 && kaugusParse <= 30)
            {
                Console.WriteLine("Sa elad vist maal. Maa elu on hää, ilus loodus ja puha, kuid raske on kindlasti.");
            }
            else if (kaugusParse >= 31 && kaugusParse <= 50)
            {
                Console.WriteLine("Sa elad vist kohaliku küla juures. Külajoodikul on kindlasti väga huvitav oma elu teile jagada.");
            }
            else if (kaugusParse >= 51 && kaugusParse <= 90)
            {
                Console.WriteLine("Sa elad vist pärapõrgus, kus elanikke pole peaaegu üldse, kuid seal on ainult Eesti sügavad metsad, kus elab karu Otto sinu kodu läheduses.");
            }
            else if (kaugusParse >= 91 && kaugusParse <= 130)
            {
                Console.WriteLine("Issand, sul vist ei vea eriti üldse või mis? Sa elad vist sama kaugel kui Tallinast Rakverre sõita. Või isegi Helsingis!");
            }
            else if (kaugusParse >= 130 && kaugusParse <= 200)
            {
                Console.WriteLine("Sa elad vist juba isegi Tartu kandis. Õpi parem seal kui Tallinas.");
            }
            else if (kaugusParse >= 250 && kaugusParse <= 500)
            {
                Console.WriteLine("Sa elad vist kuskil Eesti Läti piiri juures lähedal Või isegi elad juba Rootsis, kas või Stockholmis");
            }
            else
                Console.WriteLine("Su vanemad on kindlasti rikkad, et sulle lennupileti või laevapileti ostma igapäev, et jõuda õige ajal Tallinna Tööstushariduskeskusesse");
        }
    }
}
