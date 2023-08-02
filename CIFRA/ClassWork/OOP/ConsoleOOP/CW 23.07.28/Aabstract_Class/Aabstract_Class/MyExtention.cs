using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aabstract_Class
{
    public static class MyExtention
    {
        public static int CountChar(this string s, char c)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c) count++;
            }
            return count;
        }
    }
}