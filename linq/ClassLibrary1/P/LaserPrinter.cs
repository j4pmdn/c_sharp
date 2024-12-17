using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop;

namespace ClassLibrary1.P
{
    public class LaserPrinter : Printer
    {
        public LaserPrinter(string name): base(name) { }

        public int Resolution { get; set; } = 600;

        public override void MyAbstractMethod()
        {
        }
    }
}
