namespace _17.mai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("17.mai if ja else-i rakendus");
            Console.WriteLine("1. file | 2. file2 | 3. file3 | 4. delete | 5. check");

            // Teha rakendus kus saab if ja else abil üles leida soovitud meetod.
            // Meetod tuleb välja kutsuda.

            // 1.Esimene meetod teeb faili ekraanile.
            // 2.Teises meetodis loob faili, aga selle sisu saad sina kirjutada.
            // 3.Kolmandas meetodis loob faili, aga paneb sellisesse urli, kus seda ei ole.

            string enter = Console.ReadLine();

            if (enter == "file" || enter == "fail" || enter == "1")
            {
                CreateFile();
            }
            else if (enter == "file2" || enter == "fail2" || enter == "2")
            {
                FilePlusContent();
            }
            else if (enter == "file3" || enter == "fail3" || enter == "3")
            {
                File3();
            }
            else if (enter == "Delete" || enter == "delete" || enter == "4")
            {
                DeleteaFile();
            }
            else if (enter == "Check" || enter == "check" || enter == "5")
            {
                CheckaFile();
            }
            else if (enter == "Secretfile" || enter == "SecretFile")
            {
                SecretFile();
            }
            else
            {
                Console.WriteLine("Error");
            }

            static void CreateFile()
            {
                Console.WriteLine("Fail loodud.");
                File.Create("C:/Users/Opilane/Desktop/FileTest.txt");
            }

            static void FilePlusContent()
            {
                Console.WriteLine("Lisa selle failile mingi sisu");
                string filePath = @"C:/Users/Opilane/Desktop/aFileWithContent.txt";
                string inputText = Console.ReadLine();

                File.WriteAllText(filePath, inputText);

            }

            static void File3()
            {
                Console.WriteLine("Meetod 3");
            }

            static void DeleteaFile()
            {
                Console.WriteLine("Mis faili tahad ära kustutada?");

                string deleteFail = Console.ReadLine();
                string filePath = @"C:/Users/Opilane/Desktop/" + deleteFail + ".txt";
                File.Delete(filePath);
                Console.WriteLine("Fail sai edukalt ära kustutatud.");
            }

            static void CheckaFile()
            {
                Console.WriteLine("Kontrolli faili üle:");
                string check = Console.ReadLine(); ;
                string theFilePath = @"C:/Users/Opilane/Desktop/" + check + ".txt";

                if (File.Exists(theFilePath))
                {
                    Console.WriteLine("On olemas");
                }
                else
                {
                    Console.WriteLine("Ei eksisteeri");
                }
            }

            static void SecretFile()
            {
                Console.WriteLine("4. fail");
                Console.WriteLine("Sisesta faili pealkiri:");
                
                string topic = Console.ReadLine();
                string filePath = @"C:/Users/Opilane/Desktop/" + topic + ".txt";
                
                Console.WriteLine("faili sisu? (y/n)");
                
                string yeOrNo = Console.ReadLine();
                if (yeOrNo == "y" || yeOrNo == "Y")
                {
                    Console.WriteLine("Sisestage faili sisu:");
                    string inputText = Console.ReadLine();
                    File.WriteAllText(filePath, inputText);

                    Console.WriteLine("Fail sai edukalt loodud!");

                }
                else if (yeOrNo == "n" || yeOrNo == "N")
                {
                    Console.WriteLine("Fail sai edukalt loodud!");
                    File.Create(filePath);
                }
                else
                {
                    Console.WriteLine("Error, midagi läks valesti.");
                }
            }
        }
    }
}