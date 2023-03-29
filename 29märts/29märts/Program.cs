namespace _29märts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");
            Car car1 = new Car();
            car1.Id = 1;
            car1.Color = "Black";
            car1.CarType = "Toyota";
            car1.PlateNumber = "123ABC";

            CarDto dto = new CarDto();
            dto.Id = car1.Id;
            dto.Color = car1.Color;
            dto.CarType = car1.CarType;
            dto.PlateNumber = car1.PlateNumber;

            Console.WriteLine("Car: " + dto.Id + ", " + dto.CarType);
       
        }

    }
    public class Car
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string CarType { get; set; }
        public string PlateNumber { get; set; }
    }

    public class CarDto
    {
       public int Id { get; set; }
       public string Color { get; set; }
       public string CarType { get; set; }
       public string PlateNumber { get; set; }
    }
}
    

    
    

    
