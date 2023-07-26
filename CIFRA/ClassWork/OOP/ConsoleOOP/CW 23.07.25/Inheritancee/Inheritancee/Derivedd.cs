using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritancee
{
    internal class Derivedd: Basee
    {
        void Method()
        {
            protected_value = 10;
            internal_value = 20;
            protint_value = 30;
            public_value = 40;
        }
    }
}