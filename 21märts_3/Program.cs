using System.Runtime.CompilerServices;

namespace _21märts_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faili lugemine");

            string line;

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/luuletus.txt"))
                {
                    int count = 0;

                    while (sr.EndOfStream == false)
                    {
                        ++count;
                        line = sr.ReadLine();
                        int charLine = line.Length;
                        Console.WriteLine(count + " " + line + " " + charLine);
                    }
                    sr.Close();
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Faili ei saa lugeda");
            }
        }
    }
}