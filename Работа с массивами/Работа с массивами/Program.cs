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
            Massive test = new Massive();
            test.MassiveSHAG(10, 1, 3);
            Console.WriteLine(test.TooString());
            test.Inverse();
            Console.WriteLine(test.TooString());
            test.Multi(-2);
            Console.WriteLine(test.TooString());
            int sumaelementov = test.Summa;
            Console.WriteLine(sumaelementov);
            test.Massivernd(10,1,5);
            Console.WriteLine(test.TooString());
            Console.WriteLine(test.Summa);
            Console.WriteLine(test.Max);
            Console.WriteLine(test.Min);
            
            Console.ReadKey();
        }
    }
}
