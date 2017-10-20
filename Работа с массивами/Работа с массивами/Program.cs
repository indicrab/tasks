using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            Massive test = new Massive(10, 3, 4);
            Console.WriteLine(test.TooString());
            test.Inverse();
            Console.WriteLine(test.TooString());
            test.Multi(-2);
            Console.WriteLine(test.TooString());
            int sumaelementov = test.Summa;
            Console.WriteLine(sumaelementov);

            RandomMas test2 = new RandomMas(5, 1, 20);
            Console.WriteLine(test2.TooStringRand());
            Console.WriteLine(test2.Max);
            Console.WriteLine(test2.Min);

            Console.ReadKey();
        }
    }
}
