using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            const long merc = 57910000;
            const long ven = 108200000;
            const long eath = 149600000;
            const long mars = 227330000;
            const long jup = 778330000;
            const long ura = 2873550000;
            const long nep = 4501000000;
            const long pluto = 5945900000;

            const double AU = 6.684587123e-9;
            const double lm = 8.317;

            Console.Write("Mercury");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", merc);
            Console.WriteLine("Distance of A.U>      : {0, 0:n10} AU", AU * merc);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * merc) * lm));
            Console.WriteLine("Venus");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", ven);
            Console.WriteLine("Distance of A.U>      : {0, 0:n10} AU", AU * ven);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * ven) * lm));
            Console.WriteLine("Earth");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", eath);
            Console.WriteLine("Distance of A.U>      : {0, 0:n10} AU", AU * eath);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * eath) * lm));
            Console.WriteLine("Mars");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", mars);
            Console.WriteLine("Distance of A.U>      : {0, 0:n10} AU", AU * mars);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * mars) * lm));
            Console.WriteLine("Jupiter");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", jup);
            Console.WriteLine("Distance of A.U>      : {0, 0:n10} AU", AU * jup);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * jup) * lm));
            Console.WriteLine("Uranus");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", ura);
            Console.WriteLine("Distance of A.U>      : {0, 0:n10} AU", AU * ura);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * ura) * lm));
            Console.WriteLine("Neptune");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", nep);
            Console.WriteLine("Distance of A.U>      : {0, 0:n10} AU", AU * nep);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * nep) * lm));
            Console.WriteLine("Pluto");
            Console.WriteLine("Distance from the sun : {0, 0:n} KM", pluto);
            Console.WriteLine("Distance of A.U>      : {0, 0:n10} AU", AU * pluto);
            Console.WriteLine("light-minute          : {0, 0:n10} light minute", ((AU * pluto) * lm));
        }
    }
}
