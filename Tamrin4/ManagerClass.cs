using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin4
{
    public class ManagerList
    {
        public static List<ManagerClass> managers = new List<ManagerClass>();
    }
    public class ManagerClass
    {
        public ManagerClass()
        {
        }
        public ManagerClass(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public string name { get; set; }
        public string password { get; set; }
        public void addEmployee()
        {
            Employeeinfo newemployee = new Employeeinfo();

            Console.WriteLine("Please enter employee's ID.");
            string newemployeeid = Console.ReadLine();
            bool passcheck = EmployeeClass.employeeinfos.Any(m => m.id == newemployeeid);
            if (passcheck is true)
            {
                Console.WriteLine("This ID is already used! try another ID.");
            }
            else
            {
                newemployee.id = newemployeeid;
            }

            Console.WriteLine("Please enter employee's name.");
            newemployee.name = Console.ReadLine();

            Console.WriteLine("Please enter employee's salary.");
            newemployee.salary = Convert.ToDouble(Console.ReadLine());

            newemployee.rank = "Newbie";
            EmployeeClass.employeeinfos.Add(newemployee);

            Console.WriteLine("A new employee is added.");
            Console.WriteLine("**********************************");
            showEmployees();

        }
        public void deleteEmployee()
        {
            showEmployees();
            Console.WriteLine("Which employee do you want to Fire? (Enter ID.)");
            string firedId = Console.ReadLine();
            int index = EmployeeClass.employeeinfos.FindIndex(employee => employee.id.Equals(firedId));
            EmployeeClass.employeeinfos.RemoveAt(index);
            Console.WriteLine("**********************************");
            showEmployees();

        }
        public void promoteEmployee()
        {
            showEmployees();
            Console.WriteLine("Enter Employee's ID.");
            int index = EmployeeClass.employeeinfos.FindIndex(e => e.id == Console.ReadLine());
            Employeeinfo employee = EmployeeClass.employeeinfos[index];
            Console.WriteLine("Enter new rank.");
            employee.rank = Console.ReadLine();
            Console.WriteLine($" {employee.name} is now a {employee.rank}");
            Console.WriteLine("**********************************");
            showEmployees();
        }
        public void showEmployees()
        {
            foreach (var item in EmployeeClass.employeeinfos)
            {
                Console.WriteLine($" {item.id} \t {item.name} \t {item.rank} \t {item.salary} \t {item.gotpaid} \n ");
            }
        }
        public void paySalary()
        {
            showEmployees();
            Console.WriteLine("Choose the employee. (Enter ID)");
            string salarypayID = Console.ReadLine();
            int index = EmployeeClass.employeeinfos.FindIndex(e => e.id == salarypayID);
            Employeeinfo employee = EmployeeClass.employeeinfos[index];

            double newmoney = BankAccountClass.money - employee.salary;
            if (newmoney >= 0)
            {
                employee.gotpaid = true;
                BankAccountClass.money = newmoney;
                Console.WriteLine("Salary is paid.");
                showEmployees();
            }
            else
            {
                Console.WriteLine("You can't Pay the salary. \n *Not enough money in bank account*");
            }
        }


    }
}
