﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanWorker
{
    internal class Worker: Human
    {
        private string date;
        private string position;

        public Worker(string name, string date, string position) : base(name)
        {
            this.date = date;
            this.position = position;

        }

        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }  
        }
    }
}