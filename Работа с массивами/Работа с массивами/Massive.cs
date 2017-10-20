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
        public Massive(int razmer,int firstnum,int shag) //создаем массив и задаем его размер, первое значение и шаг для заполнения
        {
            massive = new int[razmer];
            for (int i = 0; i < razmer; i++)
                massive[i] =firstnum+shag*i;
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
        public string TooString()
        {
            string s = "";
            foreach (int value in massive)
                s = s + value + " ";
            return s;
        }

    }
}
