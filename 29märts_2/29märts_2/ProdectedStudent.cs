using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29märts_2
{
    internal class ProdectedStudent
    {
        //Kui meetod on protected, siis ei saa seda kasutada
        //teistes classides
        protected void DoSomething()
        {
            Console.WriteLine("Prodected Student");
        }
    }
}
