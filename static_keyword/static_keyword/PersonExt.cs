using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace static_keyword
{
    internal static class PersonExt
    {
        public static void Print(this Person person)
        {
            Console.WriteLine($"ID: {person.Id}");
            Console.WriteLine($"Name: {person.Name}");
        }
    }
}
