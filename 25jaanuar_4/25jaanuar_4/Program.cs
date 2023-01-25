using System;

namespace _25jaanuar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulaator");

            //muutujad
            char choice;
            int menuOptions;
            int number1, number2;

            //do e. teeb midagi
            do
            {
                //näitab konsoolis tektsi, kus saab valida erinevate tehete vahel
                Console.WriteLine("Vajuta 1 liitmiseks");
                Console.WriteLine("Vajuta 2 lahutamiseks");
                Console.WriteLine("Vajuta 3 korrutamiseks");
                Console.WriteLine("Vajuta 4 jagamiseks");
                
                //siis saad konsoolis valida tehtetüübi
                menuOptions = Convert.ToInt32(Console.ReadLine());

                //siis hakkab switch, kus sulgude sees on muutuja
                switch (menuOptions)
                {
                    // siin on erinevad kalkulatsioonid 
                    case 1:
                        Console.WriteLine("Sisesta kahe numbri väärtused:");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Kahe numbri liitmise tulemus {number1 + number2}");
                        break;

                    case 2:
                        Console.WriteLine("Sisesta kahe numbri väärtused:");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Kahe numbri lahutamise tulemus {number1 - number2}");
                        break;

                    case 3:
                        Console.WriteLine("Sisesta kahe numbri väärtused:");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Kahe numbri korrutamise tulemus {number1 * number2}");
                        break;

                    case 4:
                        Console.WriteLine("Sisesta kahe numbri väärtused:");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Kahe numbri jagamise tulemus {number1 / number2}");
                        break;

                        // kui tehakse vale valik, siis programm läheb switchist välja
                    default:
                        Console.WriteLine("Vale valik");
                        break;

                }
                //siin näitab teksti
                Console.WriteLine("Vali Y, et jätkata ja mõni teine nupp, et lõpetada");
                //sisestad tähe 
                choice = Convert.ToChar(Console.ReadLine());
                
                //kui on sisestatud Y, siis suunab algusesse, aga teiste tähemärkide puhul lõpetab programmi
            } while (char.ToUpper(choice) == 'Y');
        }
    }
}
