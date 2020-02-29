using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Programmeren_3_Linq
{
    class Select
    {
        //eens proberen deze 2 colelcties niet static te maken, zou zogezegd niet gaan? niet zeker van.
        static IList<Cursus> c = new List<Cursus>() {
            new Cursus("programmeren 1", 6),
            new Cursus("web 1",3),
            new Cursus("databanken",4),
            new Cursus("Labo",3)};
        public static IList<Student> studentList = new List<Student>()
        {
            new Student(1,"John",18){Cursussen={c[0]}},
            new Student(2,"Steve",15){Cursussen={c[1],c[2]}},
            new Student(3,"Bill",25){Cursussen={c[0],c[3],c[1]}},
            new Student(4,"Ram",28){Cursussen={c[0],c[1]}},
            new Student(5,"Ron",19)
        };
        public static void Select1()
        {
            Console.WriteLine("Select 1 ----------------");
            var sel = studentList.Select(s => s.StudentName);
            foreach(var x in sel)
                Console.WriteLine(x);
            Console.WriteLine("---------------------------");
        }
        public static void Select2()
        {
            Console.WriteLine("Select2---------------");
            var sel = studentList.Select(s => new { naam = s.StudentName, aantalCursussen = s.Cursussen.Count() });
            foreach (var x in sel) Console.WriteLine(x);
            Console.WriteLine("----------------------------");
        }
        public static void Select3()
        {
            Console.WriteLine("Select3---------------");
            var sel = studentList.SelectMany(s => s.Cursussen);
            foreach (var x in sel) Console.WriteLine(x);
            Console.WriteLine("-----------------------------------------");
        }
        public static void Select4()
        {
            Console.WriteLine("Select4-----------------------");
            var sel = studentList.SelectMany(s => s.Cursussen).Distinct();
            foreach (var x in sel) Console.WriteLine(x);
            Console.WriteLine("-------------------------------------");
        }
        public static void Select5()
        {
            Console.WriteLine("Select5----------------------");
            var sel = studentList.SelectMany(s => s.Cursussen, (student, program) => new
            {
                studentName = student.StudentName,
                cursusName = program
            });
            foreach (var x in sel) Console.WriteLine(x);
            Console.WriteLine("----------------------------------");
        }
    }
}
