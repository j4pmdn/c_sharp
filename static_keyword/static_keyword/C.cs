﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword
{
    internal static class C
    {
        public static int x = 999;

        static C()
        {
            Console.WriteLine(x);
            Console.WriteLine("[C]");
        }


        //public static void F()
        //{
        //    x = 1;
        //}
    }
}
