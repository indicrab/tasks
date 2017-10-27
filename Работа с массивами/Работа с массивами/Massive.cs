using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_массивами
{
    public class Massive
    {
        int[] massive;
        
        public int[] MassiveSHAG(int razmer, int firstnum, int shag) //создаем массив и задаем его размер, первое значение и шаг для заполнения
        {
            massive = new int[razmer];
            for (int i = 0; i < razmer; i++)
                massive[i] = firstnum + shag * i;
            return massive;
        }
        public int[] Massivernd(int razmer2, int min, int max) //создаем масив указаной размерности и заполняем егоо числам ив указаном диапазоне
        {
            massive = new int[razmer2];
            Random rnd = new Random();
            for (int i = 0; i < massive.Length; i++)
                massive[i] = rnd.Next(min, max);
            return massive;
        }


        public int Summa  //складываем элементы масива
        {
            get
            {
                int sum = 0;
                foreach (int value in massive)
                {
                    sum += value;
                }
                return sum;
            }
        }
        public int[] Inverse() //меняем знаки всех чисел массива на противоположные
        {
            for (int i = 0; i < massive.Length; i++)
                massive[i] = massive[i] * -1;
            return massive;
        }
        public int[] Multi(int mnojitel)   //умножим эдементы масива на указаное число
        {
            for (int i = 0; i < massive.Length; i++)
                massive[i] = massive[i] * mnojitel;
            return massive;
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
