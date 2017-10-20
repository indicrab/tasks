using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_массивами
{
    

    public class RandomMas 
    {
        int[] massive;
        public RandomMas(int razmer, int min, int max) //создаем масив указаной размерности и заполняем егоо числам ив указаном диапазоне
        {
            massive = new int[razmer];
            Random rnd = new Random();
            for (int i = 0; i < massive.Length; i++)
                massive[i] = rnd.Next(min, max);
        }

        public int Max  //находим макc и мин числа в массиве
        {
            get
            {
                int max = massive[0];
                for (int i = 1; i < massive.Length; i++)
                    if (massive[i] > max) max = massive[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = massive[0];
                for (int i = 1; i < massive.Length; i++)
                    if (massive[i] < min) min = massive[i];
                return min;
            }
        }

        public string TooString() // массив в строку для консоли
        {
            string s = "";
            foreach (int value in massive)
                s = s + value + " ";
            return s;
        }




    }
}
