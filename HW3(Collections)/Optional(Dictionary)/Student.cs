using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Dictionary_
{
    class Student
    {
        public string Surname { get; set; }
        public int Date { get; set; }

        public Student(string name, int date)
        {
            Surname = name;
            Date = date;
        }
    }
}
