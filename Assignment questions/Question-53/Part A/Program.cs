using System;

namespace Part_A
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Part a = ");
            int x = 20, y = 35;
            x = y++ + x++;
            y = ++y + ++x;
            Console.Write(x);
            Console.WriteLine(y);
        }
    }
}
