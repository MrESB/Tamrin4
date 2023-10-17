using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamrin4
{
    public static class Admin
    {
        public static string password = "adminadmin";
        public static void addManager()
        {
            ManagerClass newmanager = new ManagerClass();
            Console.WriteLine("PLease enter new manager's name.");
            newmanager.name = Console.ReadLine();

            Console.WriteLine("PLease enter new manager's password.");
            string newmanagerpassword = Console.ReadLine();
            bool passcheck = ManagerList.managers.Any(m => m.password == newmanagerpassword);
            if (passcheck is true)
            {
                Console.WriteLine("This password is already used! try another password.");
            }
            else
            {
                newmanager.password = newmanagerpassword;
                ManagerList.managers.Add(newmanager);
                Console.WriteLine("New manager is succesfully added.");
                Console.WriteLine("**********************************************");
                showManagers();
            }

        }
        public static void fireManager()
        {
            showManagers();
            Console.WriteLine("Which manager do you want to Fire? (Enter name.)");
            string firedname = Console.ReadLine();
            int index = ManagerList.managers.FindIndex(manager => manager.name.ToLower() == firedname.ToLower());
            ManagerList.managers.RemoveAt(index);
            Console.WriteLine("This manager is fired.");
            Console.WriteLine("**********************************************");
            showManagers();
        }
        public static void showManagers()
        {
            foreach (var item in ManagerList.managers)
            {
                Console.WriteLine($" {item.name} \t {item.password} \n");
            }
        }
    }
}
