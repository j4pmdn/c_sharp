using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDIProject
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public ConsoleMessageWriter()
        {
            Console.WriteLine("New ConsoleMessageWriter");
        }

        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
