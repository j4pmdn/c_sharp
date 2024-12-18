using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_keyword
{
    internal static class ReadableExts
    {
        public static void WriteName(this IReadable readable)
        {
            Console.WriteLine(readable.Name);
        }

    }
}
