namespace _29märts_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Enter VIN Code");

            int vinCode = Convert.ToInt32(Console.ReadLine());

            Machine machine = new Machine();
            machine.SetVINNumber(vinCode);

            Console.WriteLine("Vin code is: " + machine.GetVINCode());
        }
    }

    class Car
    {
        public void SetVINNumber(int v)
        {
            VIN = v;
        }
        protected int VIN;
    }

    class Machine : Car
    {
        public int GetVINCode()
        {
            return VIN;
        }
    }
    
}