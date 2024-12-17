using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Fish: Animal
    {
        // sealed được sử dụng để ngăn chặn việc kế thừa một lớp hoặc ghi đè một phương thức.
        public sealed override void Move()
        {
            Console.WriteLine("Swim");
        }
    }
}
