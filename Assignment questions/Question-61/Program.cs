﻿using System;

namespace Question_61
{
    class Program
    {
        static void Main(string[] args)
        {
             int a=10, b=20, c=15, d=8, e=40;
            Console.WriteLine((a + b / (c - 5)) / ((d + 7) / (e - 37) % 3));
            Console.WriteLine(a+b/c-5/d+7/e-37%3);
            Console.WriteLine(a * (b * b) - (c * b) + d);
        }
    }
}
