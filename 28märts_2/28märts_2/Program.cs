namespace _28märts_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapper");
           
            Employee emp = new Employee();
            emp.Id = 11;
            emp.Name = "Name1";
            emp.Title = "Title1";
            emp.Description = "Description1";

            EmployeeDto dto = new EmployeeDto();
            dto.Id = emp.Id;
            dto.Name = emp.Name;
            dto.title = emp.title;

            

        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string title { get; set; }
    }

    public class EmployeeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string title { get; set; }
    }


}