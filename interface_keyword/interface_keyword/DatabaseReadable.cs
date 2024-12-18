using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_keyword
{
    internal class DatabaseReadable : IDoubleReadable
    {
        public string Name => "DatabaseReadable";

        public double ReadDouble()
        {
            throw new NotImplementedException();
        }

        public int ReadInt()
        {
            return 100;
        }

        public string ReadString()
        {
            return "ABCDE";
        }
    }
}
