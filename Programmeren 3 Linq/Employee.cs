using System;
using System.Collections.Generic;
using System.Text;

namespace Programmeren_3_Linq
{
    class Employee
    {
        public Employee(int id,string name,int adressid,int departmentid)
        {
            ID = id;
            Name = name;
            AdressID = adressid;
            DepartmentID = departmentid;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int AdressID { get; set; }
        public int DepartmentID { get; set; }
    }
}
