using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Bird: Animal
    {
        public override void Move()
        {
            Console.WriteLine("Fly");
        }

        public new void A()
        {
            Console.WriteLine("Bird.A");
        }
    }
}
