namespace _29märts_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encapsulation");

            //Kui meetod on protected, siis ei saa seda kasutada
            //teistes classides

            ProdectedStudent prodectedStudent = new();
            //prodectedStudent.DoSomething();

            //Kui protected meetod on sama classis,
            //siis saab kasutada
            Program p = new Program();
            p.ProtectedMethodInSameClass();

            //internal tähendab seda, et kogu
            //selle projekti sees saab kasutada
            var protectedInternalStudent = new ProtectedInternalStudent();
            Console.WriteLine(protectedInternalStudent.ProtectedInternalStudent1);


            var PrivateProtectedStudent = new PrivateProtectedStudent();

            //ei saa kasutada kuna onprivate protected tasemel
            //PrivateProtectedStudent.PrivateProtectedStudent1 = "123";

            Program pp = new Program();
            Console.WriteLine(pp.privateProtectedInProgramClass);


            Console.WriteLine("--------Sealed Class-------");
            var sc = new SealedClass();
            sc.Id = 1;
            sc.Name = "Test";
            sc.Description = "Test";
            Console.WriteLine($"Id on {sc.Id}, Name on {sc.Name}" +
                $"ja Description on {sc.Description}");

            //ei saa kasutada kuna InternalClass asub
            //teises projektis
            //InternalClass internalClass = new();
        }

        protected void ProtectedMethodInSameClass()
        {
            Console.WriteLine("Protected Method In Same Class");
        }

        private protected string privateProtectedInProgramClass
            = "privateProtectedInProgramClass";
    }
}