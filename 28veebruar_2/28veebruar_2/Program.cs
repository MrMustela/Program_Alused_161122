using System;

namespace _28veebruar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct");
            
            //Employee emp;
            //Employee employee2 = new();
            Employee employee = new Employee();

            Employee emp;
            emp.Id = 5;
            Console.WriteLine(emp.Id);

            Employee empF;
            empF.FirstName = "Peeter";
            Console.WriteLine(empF.FirstName);

            
            
            //Console.WriteLine(employee.Id);
            //Console.WriteLine(employee.FirstName);
            //Console.WriteLine(employee.LastName);
            
        }
        
        struct Employee
        {
            public int Id;
            public string FirstName;
            public string LastName;


        }
    }
}
