using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop;

namespace ClassLibrary1
{
    internal class Class1
    {   
        // private -> chỉ được phép gọi bên trong class đó mà thôi
        internal void P()
        {
            //var printer = new Printer() { Page = 10};

            //printer.Print("Hello World");
        }

        private void P2()
        {
            P();
        }
    }
}
