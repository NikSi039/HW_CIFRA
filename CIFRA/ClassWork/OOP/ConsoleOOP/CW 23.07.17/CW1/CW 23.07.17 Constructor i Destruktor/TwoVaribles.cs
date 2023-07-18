using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._17_Constructor_i_Destruktor
{
    internal class TwoVaribles
    {
        private int a;
        private int b;

        public TwoVaribles(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        ~TwoVaribles()
        {
            System.Diagnostics.Trace.WriteLine("Объект удален");
        }
    }
}
