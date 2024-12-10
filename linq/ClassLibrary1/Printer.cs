using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop
{
    public class Printer
    {
        private string name;

        public int Page { get; set; }

        public Printer() {
            name = string.Empty;
            Console.WriteLine("----- NEW PRINTER ----");
        }

        public Printer(string name, int page)
        {
            this.name = name;
            this.Page = page;
            Console.WriteLine($"----- NEW PRINTER: {name} -----");
        }

        // internal -> chỉ được phép truy cập bên trong project(assembly)
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
