namespace _28märts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faili harjutused");
            Console.WriteLine("\nSisesta õige fail URL lõpuni");
            string url = Console.ReadLine();

            string filePath = @"C:/Users/Opilane/Desktop/" + url;

            if (url == "WriteToFile.txt")
            {
                Console.WriteLine("Correct!");

                Console.WriteLine("Sisesta mingi text siia");
                string inputText = Console.ReadLine();
                File.WriteAllText(filePath, inputText);


            }

            else
                Console.WriteLine("ERROR!");

            
        }
    }
}