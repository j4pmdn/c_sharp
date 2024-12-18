using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_keyword
{
    internal interface IDoubleReadable: IReadable
    {
        double ReadDouble();
    }
}
