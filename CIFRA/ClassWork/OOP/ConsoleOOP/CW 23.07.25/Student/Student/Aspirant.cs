using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentsss
{
    internal class Aspirant: Student
    {
        public string? ScientistPurpose { get; set; }

        public new int getScolarship()
        {
            if (AverageMark == 5) return 25000;
            else return 15000;
        }
    }
}