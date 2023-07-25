using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_23._07._24_PPartial_Classs
{
    public partial class Person
    {
        private int age;
        public partial void Read();

        public Person(string name)
        {
            this.name = name;
            this.age = 0;
        }
        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public void Move()
        {
            Console.WriteLine("I am moving");
        }
    }
}