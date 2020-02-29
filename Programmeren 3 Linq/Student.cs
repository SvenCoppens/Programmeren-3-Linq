using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3_Linq
{
    class Student
    {
        public Student(int id,string name, int age)
        {
            StudentID = id;
            StudentName = name;
            Age = age;
        }
        public List<Cursus> Cursussen = new List<Cursus>();
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return ($"{Age},{StudentName},{StudentID}");
        }

    }
}
