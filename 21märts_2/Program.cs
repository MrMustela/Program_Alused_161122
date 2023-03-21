using System.Numerics;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Text;

namespace _21märts_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta otsitav sõna");
            Console.WriteLine("Kasuta formaati 's--a, kus " +
            "- tähistab tundmatut tähte");

            string choice = Console.ReadLine();

            WordFinder(choice);
        }

        private static void WordFinder (string choice)
        {
            Regex resularExp = new Regex(@"\b" + choice.Replace("-", "\\w"),
                RegexOptions.Compiled | RegexOptions.IgnoreCase);

            try
            {
                using (StreamReader sr = new StreamReader("C:/Users/opilane/Desktop/lemmad.txt", Encoding.Default))
                {
                    int lineNumber = 0;

                    while (sr.EndOfStream == false)
                    {
                        string line = sr.ReadLine();

                        if (line.Length == choice.Length)
                        {
                            MatchCollection matches = resularExp.Matches(line);

                            if (matches.Count > 0)
                            {
                                lineNumber++;
                                Console.WriteLine(lineNumber + " " + line);
                            }
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ei ole olemas selise pikkusega sõna");
                Console.WriteLine(ex.Message);
                throw;
            }
            Console.ReadKey();
        }
    }
}