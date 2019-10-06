using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, x = 5, y = 2,q,w,e,r,t,u,i,o,p,d;
            q = a + b;
            Console.WriteLine(q);
            w = x - b;
            Console.WriteLine(w);
            e = x * b;
            Console.WriteLine(e);
            r = y / a;
            Console.WriteLine(r);
            t = b % y;
            Console.WriteLine(t);
            u = y + 10 % x;
            Console.WriteLine(u);
            i = a / 3 * 5;
            Console.WriteLine(i);
            o = 9 / 2 * a;
            Console.WriteLine(o);
            p = y % 8;
            Console.WriteLine(p);
            d = 100 * x + y % 2 - a;
            Console.WriteLine(d);
        }
    }
}
