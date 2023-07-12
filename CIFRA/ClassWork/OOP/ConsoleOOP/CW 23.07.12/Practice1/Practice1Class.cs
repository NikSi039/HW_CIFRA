using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Practice1Class
    {
        private int value1;
        private int value2;

        public void setValue1(int v1)
        {
            value1 = v1;
        }

        public void setValue2(int v2)
        {
            value2 = v2;
        }

        public int getValue1()
        {
            return value1;
        }

        public int getValue2()
        {
            return value2;
        }

        public int Sum()
        {
            return value1 + value2; 
        }

        public int Max()
        {
            int max = value1;

            if (value2 > max)
            {
                max = value2;
            }
            return max;
        }
    }
}
