using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._17_Constructor_i_Destruktor
{
    internal class Third
    {
        private TwoVaribles var;

        public Third()
        {
            var = new TwoVaribles(10, 10);
        }
    }
}
