using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Indeksator
{
    internal class Second: ZelChislo
    {
        public int SecondChislo { get; set; }

        public override int this[int i]
        {
            get
            {
                string t1 = Chislo.ToString();
                string t2 = SecondChislo.ToString();

                if (i < t1.Length && i < t2.Length)
                {
                    return int.Parse(t1[i].ToString()) + int.Parse(t2[i].ToString());
                }
                else
                {
                      throw new Exception("Такого индекса нет в классе");
                }

               
            } 

        }
        public int this[int i, int j]
        {
            get
            {
                if (i == 1)
                {
                    string temp = Chislo.ToString();

                    if (i < temp.Length)
                    {
                        return int.Parse(temp[i].ToString());

                    }
                    else throw new Exception("Такого индекса нет в классе");
                }
                else
                {
                    string temp = SecondChislo.ToString();

                    if (i < temp.Length)
                    {
                        return int.Parse(temp[i].ToString());

                    }
                    else throw new Exception("Такого индекса в числе нет");
                }




            }
        }
    }
}
