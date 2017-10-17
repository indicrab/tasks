using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сумма_нечет_чисел
{
    class Program
    {
        //С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
        //Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран.
        //test for github
        
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int summ = 0;
            while (a != 0)
            {
                a = int.Parse(Console.ReadLine());
                if (a % 2 != 0) summ = summ + a;
            }
            Console.WriteLine(summ);

            Console.ReadKey();
        }
    }
}
