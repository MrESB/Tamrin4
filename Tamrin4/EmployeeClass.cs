using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin4
{
    public class EmployeeClass
    {
        public static List<Employeeinfo> employeeinfos = new List<Employeeinfo>();

    }
    public class Employeeinfo
    {
        public Employeeinfo() { }
        public Employeeinfo(string id, string name, string rank, double salary)
        {
            this.id = id;
            this.name = name;
            this.rank = rank;
            this.salary = salary;
            gotpaid = false;
        }
        public string id { get; set; }
        public string name { get; set; }
        public string rank { get; set; }
        public double salary { get; set; }
        public bool gotpaid { get; set; }



    }
}
