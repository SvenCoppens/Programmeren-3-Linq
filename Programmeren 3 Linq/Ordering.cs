using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Programmeren_3_Linq
{
    class Ordering
    {
        public static IList<Student> studentList = new List<Student>() { new Student(1, "John", 18),
                                                            new Student(2,"Steve",15),
                                                            new Student(3,"Bill",25),
                                                            new Student(4,"Ram",19),
                                                            new Student(5,"Ron",19)
                                                            };
        public static void Order1()
        {
            Console.WriteLine("Order 1");
            var studentsInAscOrder = studentList.OrderBy(s => s.StudentName);
            foreach(var x in studentsInAscOrder)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("----------------------------------------");
        }
        public static void Order2()
        {
            Console.WriteLine("Order 2");
            var studentsInDescOrder = studentList.OrderByDescending(s => s.StudentName);
            foreach(Student stud in studentsInDescOrder)
            {
                Console.WriteLine(stud);
            }
            Console.WriteLine("---------------------------------------");
        }
        public static void Order3()
        {
            Console.WriteLine("order3");
            var studentsInOrder = studentList.OrderBy(s => s.Age).ThenBy(s => s.StudentName);
            foreach(Student x in studentsInOrder)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("--------------------------------------------------------");
        }

        public static void Order4()
        {
            Console.WriteLine("Order 4");
            var studentsInReverseOrder = studentList.OrderBy(s => s.Age).ThenBy(s => s.StudentName).Reverse();
            foreach(Student x in studentsInReverseOrder)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
