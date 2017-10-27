using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LogincheckRegex
{
    //Создать программу, которая будет проверять корректность ввода логина. 
    //Корректным логином будет строка от 2-х до 10-ти символов, содержащая только буквы и цифры, 
    //и при этом цифра не может быть первой.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter login");
            var log = Console.ReadLine();
            LoginTest(log);
            Console.ReadKey();
            
        }
        static void LoginTest(string login)
        {

            var reg = new Regex(@"^[^0-9]\w{1,10}$", RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace);
            if (reg.IsMatch(login))
            {
                Console.WriteLine("login is correct");
            }
            else
            {
                Console.WriteLine("wrong login");
            }
        }
    }
}
