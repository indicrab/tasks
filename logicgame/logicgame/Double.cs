using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicgame
{
    class Double
    {
        public Double()
        {
            
        }

        public int current = 1; //текущее число
        
        public void PlusOne()
        {
            current += 1;
        }
        public void DoubleNum()
        {
            current *= 2;
        }
        public void SetToOne()
        {
            current = 1;
        }
        public int Current
        {
            get
            {
                return current;
            }
        }
       

        

    }
}
