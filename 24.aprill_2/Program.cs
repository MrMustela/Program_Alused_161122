namespace _24.aprill_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Experiment. Ises. ; Vabatahtlik (24.04.2023)
            Console.WriteLine("Ruudu tegemine");
            Square();
            Console.WriteLine("\n------------");
            Square2();
            Console.WriteLine("\n------------");
            Pyramide();
            static void Square()
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("* ");
                    }
                }
            }
            static void Square2()
            {
                int sum = 5;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < sum; j++)
                    {
                        Console.Write("* ");
                        if (i == 1 && j == 0)
                        {
                            for (int k = 0; k < 0; k++)
                            Console.Write("ok");
                        }

                        else if (i == 2 && j == 0)
                        {
                            for (int k = 0; k < 6; k++)
                                Console.Write(" ");
                        }
                        
                        else if (i == 3 && j == 0)
                        {
                            for (int k = 0; k < 6; k++)
                                Console.Write(" ");
                        }
                    }
                }
            }

            static void Pyramide()
            {
                int tarn = 0;
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine();
                    tarn++;
                    for (int j = 0; j < tarn; j++)
                    {
                        Console.Write("* ");
                    }
                }
            }
        }
    }
}