using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Programmeren_3_Linq
{
    class GroupBy_en_Lookupcs
    {
        static IList<Student> studentList = new List<Student>()
        {
            new Student(1,"Bill",18),
            new Student(2,"Steve",21),
            new Student(3,"Bill",18),
            new Student(4,"Ram",20),
            new Student(5,"Abram",21),
        };
        public static void group1() 
        {
            Console.WriteLine("group1 -------------------------");
            var groupedResult = studentList.GroupBy(s => s.Age);
            Console.WriteLine(groupedResult.GetType());
            foreach(var ageGroup in groupedResult)
            {
                Console.WriteLine($"Age Group{ageGroup.Key}");

                foreach(Student s in ageGroup)
                    Console.WriteLine($"Student name: {s.StudentName}");
            }
            Console.WriteLine("----------------------------------------");
        }
        public static void group2()
        {
            Console.WriteLine("---------------------------------");
            var groupedResult = studentList.ToLookup(s => s.Age);
            Console.WriteLine(groupedResult.GetType());
            foreach(var ageGroup in groupedResult)
            {
                Console.WriteLine($"Age Group: {ageGroup.Key}");
                foreach(Student s in ageGroup)
                    Console.WriteLine($"Student Name: {s.StudentName}");
            }
            Console.WriteLine("-------------------------------");
        }
        public static void group3()
        {
            var groupedResult = studentList.GroupBy(s => new { s.Age, s.StudentName });
            Console.WriteLine(groupedResult.GetType());
            foreach(var ageGroup in groupedResult)
            {
                Console.WriteLine($"Age group{ageGroup.Key}");
                foreach(Student s in ageGroup)
                    Console.WriteLine($"Student Name: {s.StudentName}");
            }
            Console.WriteLine("-------------------------");

        }
    }
}
