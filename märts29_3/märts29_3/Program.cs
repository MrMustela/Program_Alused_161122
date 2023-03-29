namespace märts29_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance");
            Console.WriteLine("Insert two numbers: ");
            Console.WriteLine("First number: ");
            int firstNr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Rectangle rectangle = new ();
            rectangle.SetHeight(firstNr);
            rectangle.SetWidth(secondNumber);

            Console.WriteLine("Total area: {0}", rectangle.GetArea());
        }
    }

    class Shape
    {
        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }

        protected int width;
        protected int height;
    }

    //Kooloniga toimub viitamine Shape classile
    class Rectangle : Shape
    {
        public int GetArea()
        {
            return (width * height);
        }
    }
}