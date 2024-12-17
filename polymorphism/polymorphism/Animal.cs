using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Animal
    {

        public virtual void Move()
        {
            Console.WriteLine("Move");
        }

        public void A()
        {
            Console.WriteLine("Animal.A");
        }

    }
}
