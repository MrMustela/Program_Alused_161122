namespace _22.mai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ises. 22.05.2023 
            Console.WriteLine("Mapper");
            Console.WriteLine("Info rongi kohta");

            Train eng = new Train();
            eng.Id = 10;
            eng.Name = "Stadler FLIRT";
            eng.Wagons = 5;
            eng.Length = 100;
            eng.Driver = "Trevor Kiir";
            eng.Built = 2012;

            TrainDto vagDto = new TrainDto();
            vagDto.Id = eng.Id;
            vagDto.Name = eng.Name;
            vagDto.Wagons = eng.Wagons;
            vagDto.Length = eng.Length;
            vagDto.Driver = eng.Driver;
            vagDto.Built = eng.Built;

            Console.WriteLine("\nTrain Id: " + vagDto.Id + " \nTrain Name: " +
                vagDto.Name + " \nTotal Wagons: " + vagDto.Wagons +
                " \nTrain Length: " + vagDto.Length + "m" + " \nTrain driver name: "
                + vagDto.Driver + " \nTrain built: " + vagDto.Built);

        }

        public class Train
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Wagons { get; set; }
            public int Length { get; set; }
            public string Driver { get; set; }
            public int Built { get; set; }
        }

        public class TrainDto
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Wagons { get; set; }
            public int Length { get; set; }
            public string Driver { get; set; }
            public int Built { get; set; }
        }
    }
}