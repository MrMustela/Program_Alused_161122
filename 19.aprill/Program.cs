using System;

namespace _19.aprill
{
    internal class Program
    {
        //static string ReverseString(string s)
        //{
        //    char[] array = s.ToCharArray();
        //    Array.Reverse(array);
        //    return new string(array);
        //}
        
        
        static void Main(string[] args)
        {
            //19.04.2023: Püramiidi meetod on pooleli!
            Console.WriteLine("Switchi harjutus. Ises.");
            Console.WriteLine("Sisesta mingi juhtum");
            Console.WriteLine("1. ruudu tegemine");
            Console.WriteLine("2. püramiidi tegemine");
            Console.WriteLine("3. tagurpidi meetod");
            Console.WriteLine("4. numbrid ühe võrra järjest ühes reas (1-10)");

            string shapes = Console.ReadLine();
            switch (shapes)
            {
                case "ruut":
                    Square();
                    break;

                case "1":
                    Square();
                    break;


                case "püramiid":
                    Pyramide();
                    break;

                case "2":
                    Pyramide();
                    break;

                case "tagurpidi":
                    Backward();
                    break;

                case "3":
                    Backward();
                    break;

                case "horisontaal":
                    OneRow();
                    break;

                case "4":
                    OneRow();
                    break;


                default:
                    Console.WriteLine("Ei leidnud!");
                    break;
            }
            static void Square()
            {
                Console.WriteLine("esimene külg");
                int nr1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("teine külg");
                int nr2 = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < nr1; i++)
                {
                    Console.WriteLine();
                    
                    for (int j = 0; j < nr2; j++)
                    {
                        Console.Write("* ");
                    }
                }
                int result = nr1 * nr2;
                int result2 = nr1 * 2 + nr2 * 2; 
                Console.WriteLine("\nPindala on: " + result);
                Console.WriteLine("ümbermõõt on: " + result2);
            }
            static void Pyramide()               
            {
                //Pooleli!
                int test = 0;
                for (int i = 1; i < 5; i++)
                {
                    test++;
                    Console.WriteLine();

                    for (int j = 0; j < test; j++)
                    {
                        Console.Write("*");
                    }
                }
            }
            //static void Backward()
            //{
            //    Console.WriteLine("Sisesta sõna:");
            //    string revWord = Console.ReadLine();
            //    Console.WriteLine("Tulemus: ");
            //    Console.WriteLine(ReverseString(revWord));            
            //}
            static void Backward()
            {
                Console.WriteLine("\nSisesta sõna: ");

                string word = Console.ReadLine();
                
                int length;
                string word1 = "";
                
                length = word.Length - 1;

                for (int i = length; i >= 0; i--)
                {
                    word1 = word1 + word[i];
                }

                Console.WriteLine("Tulemus: " + word1);
            }
            static void OneRow()
            {
                Console.WriteLine("Esimene rida numbritega (1-10)");
                
                for (int num = 0; num < 10; num++)
                {
                    int nrRow = num + 1;
                    Console.Write(nrRow);
                }
            }
        }
    }
}