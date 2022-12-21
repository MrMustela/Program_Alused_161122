using System;

namespace _21detsember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start:

            Console.Title = "Kuju valimine ja arvutamine"; //aknale nime panemine
            Console.WriteLine("Vali, mis kujundit soovid arvutada ja kujutada ning kirjuta konsoolile");

            Console.WriteLine("\n1. Ruut");
            Console.WriteLine("2. Teemant");
            Console.WriteLine("3. Ristkülik");
            Console.WriteLine("4. Kolmnurk");
            Console.WriteLine("5. Maja"); //20.12.22 (1)

            string shape = Console.ReadLine();

            switch (shape)
            {
                case "ruut":
                    Quadrilateral();
                    break;

                case "teemant":
                    Diamond();
                    break;

                case "ristkülik":
                    Rectangle();
                    break;

                case "kolmnurk":
                    Triangle();
                    break;

                case "maja": //(1)
                    House();
                    break;

                default:
                    Console.WriteLine("\nVale. Valikut ei tehtud.");
                    break;
            }
            Console.ReadKey();
            //goto Start;



        }

        private static void Quadrilateral()
        {
            Console.WriteLine("\nSisesta ruudu ühe külje mõõtühik sentimeetrites: ");
            double quadrilateral = double.Parse(Console.ReadLine());


            for (int row = 1; row <= quadrilateral; row++)
            {
                for (int column = 1; column <= quadrilateral; column++)
                {
                    string mark;
                    if (row == column || row + column <= row + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();

            }

            Console.WriteLine("Ruudu ümbermõõt on: " + quadrilateral * 4);
            Console.WriteLine("Ruudu pindala on: " + quadrilateral * quadrilateral);
        }

        private static void Diamond()
        {
            double i, j, diamond;

            Console.WriteLine("\nSisesta teemanti raadiuse mõõtühik sentimeetrites");
            diamond = double.Parse(Console.ReadLine());



            for (i = 0; i <= diamond; i++)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (i = diamond - 1; i >= 1; i--)
            {
                for (j = 1; j <= diamond - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            const double pi = 3.14159;
            Console.WriteLine("Teemandi ümbermõõt on: " + 2 * pi * diamond);
            Console.WriteLine("Teemandi pindala on: " + pi * diamond * diamond);
        }

        private static void Rectangle()
        {
            Console.WriteLine("\nSisesta ristk[liku kahe k[lje m[[t]hik sentimeetrites");

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());


            for (int row = 1; row <= a; row++)
            {
                for (int column = 1; column <= b; column++)
                {
                    string mark;
                    if (row == column || row + column <= +1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ristküliku ümbermõõt on: " + 2 * (a + b));
            Console.WriteLine("Ristküliku pindala on: " + a * b);
        }

        private static void Triangle()
        {
            Console.WriteLine("\nSisesta v]rdk[lgse kolmnurga k[lje pikkus sentimeetrites");
            //Kodus võin ise edasi mõelda, et kuidas pindala kätte saada. Hetkel olen suutnud saada kolmnurga aluse ja ümbermõõdu arvu. Ma olen ikka nii kuradi aeglane. - 20.12.22
            int length = Convert.ToInt32(Console.ReadLine());

            int answer1 = length * 2 - 1;
            int answer2 = length + length + answer1;

            for (int row = 1; row <= length; row++)
            {
                for (int column = 1; column <= length * 2 - 1; column++)
                {
                    string mark = "";

                    if (row == length)
                    {
                        mark = "*";
                    }
                    else if (row + column >= length + 1 && column - length + 1 <= row)
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }


            Console.WriteLine("Kolmnurga ümbermõõt on: " + answer2);
            Console.WriteLine("Kolmnurga pindala on: ");
            Console.WriteLine("Kolmnurga alus on: " + answer1);

        }
        private static void House()
        {
            Console.WriteLine("\nSisesta maja ruudu mõõtühiku sentimeetrites");
            int QuadrilateralH = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nSisesta maja katuse võrdkülgse kolmnurga külje pikkus sentimeetrites");
            int QuadrilateralH2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            int test = 1;
            for (int ii = 1; ii <= QuadrilateralH2; ii++)
            {
                Console.WriteLine();
                for (int jj = 1; jj <= test; )
                {
                    Console.Write("*");
                    jj++;
                }
                ii++;
                Console.Write("*");
            }
            

            for (int row = 1 ; row <= QuadrilateralH;)
            {
                Console.WriteLine();

                for (int column = 1 ; column <= QuadrilateralH; column++)
                {
                    Console.Write("* ");
                    
                }

                row++;
            }
            Console.WriteLine();


        }
    } 
}
        
    

