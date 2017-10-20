using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicgame
{
    /*Существует алгоритмическая игра “Удвоитель”. В этой игре человеку предлагается какое-то число, 
    а человек должен, управляя роботом “Удвоитель”, достичь этого числа за минимальное число шагов. 
    Робот умеет выполнять несколько команд: увеличить число на 1, умножить число на 2 и сбросить число до 1. 
    Начальное значение удвоителя равно 1. 
    Реализовать класс “Удвоитель”.  Класс хранит в себе поле current - текущее значение.  
    Методы: увеличить число на 1, увеличить число в два раза, 
    сброс текущего до 1, свойство Current, которое возвращает текущее значение.
    Создать с помощью этого класса игру, 
    в которой компьютер загадывает число, а человек. выбирая из меню на экране, 
    отдает команды удвоителю и старается получить это число за наименьшее число ходов. 
    Если человек получает число больше положенного, игра прекращается.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 100;
            int count=0;
            Random rnd = new Random();
            int finish = rnd.Next(min, max);
            Double game = new Double();
            Console.WriteLine("Command 'plus' to +1  Comand 'mult' to *2  Comand 'set' to set number and counts to 1");
            Console.WriteLine($"run to {finish} number");
            
            do
            {
                count++;
                Console.WriteLine("it yours {0} try Enter command",count);
                Console.WriteLine(game.Current);
                var comand = Console.ReadLine();
                if (comand == "plus")
                {
                    game.PlusOne();
                    
                }
                if (comand == "mult")
                {
                    game.DoubleNum();
                    
                }
                if (comand == "set")
                {
                    count = 0;
                    game.SetToOne();
                   
                }
            }
            while (game.Current != finish);
            if (game.Current == finish)
            {
                Console.WriteLine("Congrats you win with {0} counts",count);
            }
            Console.ReadKey();
            
        }
    }
}
