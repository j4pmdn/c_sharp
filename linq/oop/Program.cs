using System.Reflection;
using ClassLibrary1;

namespace oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer("Laser", 5)
            {
                Page = 10
            };

            var laserPrinter = new LaserPrinter();

            printer.Print("Hello World");
        }
    }


}
