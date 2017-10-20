using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Работа_с_массивами
{
    

    public class RandomMas 
    {
        public int[] masive;
        public RandomMas(int razmer, int min, int max) //создаем масив указаной размерности и заполняем егоо числам ив указаном диапазоне
            
        {
            masive = new int[razmer];
            Random rnd = new Random();
            for (int i = 0; i < razmer; i++)
                masive[i] = rnd.Next(min, max);
        }
        public int Max  //находим макc и мин числа в массиве
        {
            get
            {
                int max = masive[0];
                for (int i = 1; i < masive.Length; i++)
                    if (masive[i] > max) max = masive[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = masive[0];
                for (int i = 1; i < masive.Length; i++)
                    if (masive[i] < min) min = masive[i];
                return min;
            }
        }
        public string TooStringRand()
        {
            string s = "";
            foreach (int value in masive)
                s = s + value + " ";
            return s;
        }


    }
}
