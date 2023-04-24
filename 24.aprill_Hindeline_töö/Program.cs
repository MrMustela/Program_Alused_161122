namespace _24.aprill_Hindeline_töö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teha switch rakendus kus on kolm case-i.

            //Esimese case puhul kutsutakse välja meetod, mis küsib sinu nime

            //Teise puhul kutsutakse välja meetod, kus toimub vanuse küsimine.
            //Kui vastad, et oled alla 18 aastane, siis rakendus vastab, et oled alaealine.

            //Kolmanda puhul kutsutakse välja meetod kus kontrollitakse õpperühma.
            //Kui vastad TITpe22, siis ütleb, et oled õiges rühmas.
            Console.WriteLine("Kontrolltöö");

            Console.WriteLine("\nSisesta numbri järgi (1-3).");

            Console.WriteLine("\nEsimene küsib sinu nime");
            Console.WriteLine("Teine küsib sinu vanust");
            Console.WriteLine("kolmas kontrollib sinu õpperühma");

            int caseNum = Convert.ToInt32(Console.ReadLine());
            switch (caseNum)
            {
                case 1:
                    YourName();
                    break;

                case 2:
                    YourAge();
                    break;

                case 3:
                    YourGroup();
                    break;
            }

            static void YourName()
            {
                Console.WriteLine("Mis on sinu nimi?");
                string name = Console.ReadLine();
                Console.WriteLine("Tere, " + name + "!");
            }

            static void YourAge()
            {
                Console.WriteLine("Mis on sinu vanus?");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 17)
                {
                    Console.WriteLine("Oled alaealine");
                }
                else if (age >= 18)
                {
                    Console.WriteLine("Oled täisealine");
                }
            }

            static void YourGroup()
            {
                Console.WriteLine("Mis õpperühmas sa oled?");
                string group = Console.ReadLine();
                if (group == "TITpe22")
                {
                    Console.WriteLine("Sa oled õiges rühmas.");
                }
                else
                {
                    Console.WriteLine("Sa ei tohiks siin olla. Sa oled vales rühmas.");
                }
            }
        }
    }
}