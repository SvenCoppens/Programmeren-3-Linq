using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programmeren_3_Linq
{
    class Filter
    {
        public static IList<Student> studentList = new List<Student>() { new Student(1, "John", 18),
                                                            new Student(2,"Steve",15),
                                                            new Student(3,"Bill",25),
                                                            new Student(4,"Ram",19),
                                                            new Student(5,"Ron",19)
                                                            };
        public static void ShowFilter1()
        {
            Console.WriteLine("Filter1");
            IEnumerable<Student> filteredResult = studentList.Where(s => s.Age > 18 && s.StudentName.Length > 3);
            foreach (var std in filteredResult)
                Console.WriteLine(std.StudentName);
        }
        public static void ShowFilter2()
        {
            Console.WriteLine("Filter 2");
            IList<Student> filtereResult = studentList.Where((s, i) =>
            {
                if (i % 2 == 0)
                    return true;
                return false;
            }).ToList();

            foreach (var std in filtereResult)
                Console.WriteLine(std.StudentName);
        }
    }
}
