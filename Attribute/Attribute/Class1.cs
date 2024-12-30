using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeCSharp
{
    internal class Class1
    {
        [DBMethod("Customers1")]
        public void PrintHelloWorld1()
        {
            Console.WriteLine("Hello, Customers!");
        }

        [DBMethod("Users1")]
        public void PrintHelloWorld2()
        {
            Console.WriteLine("Hello, Users!");
        }
    }
}