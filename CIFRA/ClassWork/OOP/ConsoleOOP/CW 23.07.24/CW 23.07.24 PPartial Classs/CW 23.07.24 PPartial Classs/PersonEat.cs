using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._24_PPartial_Classs
{
    public partial class Person
    {
        private string name;
       public partial void Read()
        {
            Console.WriteLine("I am reading");
        }

        public Person(int age)
        {
            this.age = age;
            this.name = "";
        }

        public Person()
        {
        }

        public void Eat()
        {
            Console.WriteLine("I am eating");
        }
    }
}
