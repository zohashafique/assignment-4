﻿using System;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 4;
            ++a;
            a *= ++b;
            Console.WriteLine(a);
        }
    }
}
