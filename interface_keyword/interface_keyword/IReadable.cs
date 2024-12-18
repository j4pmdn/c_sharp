using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_keyword
{
    internal interface IReadable
    {
        string Name { get; }
        int ReadInt();
        string ReadString();
    }
}
