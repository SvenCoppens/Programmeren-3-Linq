using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Programmeren_3_Linq
{
    class ElementAt_first_last
    {
        static List<Student> studentList = new List<Student>()
        {
            new Student(1,"John",18),
            new Student(2,"Steve",15),
            new Student(3,"Bill",25),
            new Student(4,"Ram",20),
            new Student(5,"Ron",19)
        };
        public static void ElementAt()
        {
            Console.WriteLine(studentList.ElementAt(1));
            Console.WriteLine(studentList.ElementAt(4));
            Console.WriteLine(studentList.ElementAtOrDefault(1));
            Console.WriteLine(studentList.ElementAtOrDefault(7));
            //Console.WriteLine(studentList.ElementAt(7));
        }
        public static void TakeWhile()
        {
            foreach(var x in studentList.Take(2))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("---------------------------------");
            foreach(var x in studentList.TakeWhile(s => s.StudentName.Length > 3))
            {//geeft alle elementen terug waar de studentennaam langer is dan 3 karakters.
                Console.WriteLine(x);
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
