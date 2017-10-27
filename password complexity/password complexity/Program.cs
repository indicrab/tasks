using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace password_complexity
{
    class Program
    {
        //создать программу, которая проверяет сложность пароля от 4 до 16 имсволов
        //легкий пароль, только симолы или только цифры
        //средний пароль, символы  и цифры 
        //сложный пароль символ верхнего и нижнего регистра, цифры и симолвы
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Pass(password);
            Console.ReadKey();
        }
        
        static void Pass(string pas)
        {
            var low = new Regex(@"^[a-z] | [0-9]{3,16}$", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            var mid = new Regex(@"^[A-z0-9]{3,16}$", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            var hard = new Regex(@"^[A-z0-9]{3,16}\!@#$%^&*()_+$", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);

            if (low.IsMatch(pas))
            {
                Console.WriteLine("low complexity");
            }
            else if (mid.IsMatch(pas))
            {
                Console.WriteLine("mid complexity");
            }
            else if (hard.IsMatch(pas))
            {
                Console.WriteLine("hard complexity");
            }
        }
        
    }
}
