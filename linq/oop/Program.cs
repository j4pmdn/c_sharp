using System.Reflection;
using ClassLibrary1;
using ClassLibrary1.P;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var printer = new Printer("Laser", 5)
            //{
            //    Page = 10
            //};

            var laserPrinter = new LaserPrinter("abc")
            {
                Page = 250
            };

            var a = new A();
            a.A1();
            a.B1();

           // printer.Print("Hello World");
        }
    }


}
