using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_keyword
{
    internal class ConsoleReadable : IDoubleReadable
    {
        public string Name => "ConsoleReadable";

        public double ReadDouble()
        {
            Console.Write("Nhap double: ");
            return double.Parse(Console.ReadLine());
        }

        public int ReadInt()
        {
            Console.Write("Nhap int: ");
            return int.Parse(Console.ReadLine());   
        }

        public string ReadString()
        {
            Console.Write("Nhap string: ");
            return Console.ReadLine();
        }
    }
}
