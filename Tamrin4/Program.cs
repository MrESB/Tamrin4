using Tamrin4;

internal class Program
{

    private static void Main(string[] args)
    {
        //Add some managers manually.
        ManagerClass manager1 = new ManagerClass("Ali Rezaii", "123");
        ManagerList.managers.Add(manager1);
        ManagerClass manager2 = new ManagerClass("Reza Alipoor", "456");
        ManagerList.managers.Add(manager2);
        ManagerClass manager3 = new ManagerClass("Hossein Moghaddam", "789");
        ManagerList.managers.Add(manager3);
        //Add some employees manually.
        Employeeinfo emp1 = new Employeeinfo("13645", "Hassan Hosseinzadeh", "Newbie", 1300000);
        EmployeeClass.employeeinfos.Add(emp1);
        Employeeinfo emp2 = new Employeeinfo("18576", "Nima Karimi", "Newbie", 1300000);
        EmployeeClass.employeeinfos.Add(emp2);
        //Program Starts.
        Console.WriteLine("welcome.");
        Console.WriteLine("\n If you're admin, please enter 1 \n if you're a Manager, please enter 2.");
        int Choice = Convert.ToInt32(Console.ReadLine());
        switch (Choice)
        {
            case 1:
                //Entered as admin.
                Console.WriteLine("Please Enter your password.");
                if (Console.ReadLine() == "adminadmin")
                {
                    //Admin entered correct password.
                    Console.WriteLine("\n Hello admin. \n  What do you want to do?");

                    Console.WriteLine("\n To add a new manager, enter 1 \n " +
                                      "To fire a manager, enter 2 \n" +
                                      "To see a list of managers, enter 3 \n" +
                                      "To exit, enter 0");

                    int admintaskchoice = Convert.ToInt32(Console.ReadLine());
                    switch (admintaskchoice)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            Admin.addManager();
                            break;
                        case 2:
                            Admin.fireManager();
                            break;
                        case 3:
                            Admin.showManagers();
                            break;
                    }
                }
                else
                {   //Admin entered wrong password
                    Console.WriteLine("your password is incorrect! please try again.");
                }
                break;
            case 2:
                //Entered as manager.

                Console.WriteLine("Please Enter your name.");
                string entername = Console.ReadLine();

                Console.WriteLine("Please Enter your password.");
                string enterpassword = Console.ReadLine();

                ManagerClass entermanager = new ManagerClass();
                entermanager.name = entername;
                entermanager.password = enterpassword;
                bool passcheck = ManagerList.managers.Any(e => e.name == entermanager.name && e.password == entermanager.password);
                if (passcheck is true)
                {
                    //Manager entered correct password.

                    ManagerClass manager = new ManagerClass();

                    Console.WriteLine("To see a list of employees, enter 1 \n" +
                                      "To recruit a new employee, enter 2 \n" +
                                      "To fire an employee, enter 3 \n" +
                                      "To promote an employee Enter 4 \n" +
                                      "To Pay Salaries, Enter 5 \n" +
                                      "To exit, enter 0 \n");


                    int managertaskchoice = Convert.ToInt32(Console.ReadLine());
                    switch (managertaskchoice)
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            manager.showEmployees();
                            break;
                        case 2:

                            manager.addEmployee();
                            break;
                        case 3:
                            manager.deleteEmployee();
                            break;
                        case 4:
                            manager.promoteEmployee();
                            break;
                        case 5:
                            manager.paySalary();
                            break;

                    }
                }
                else
                {
                    //Manager intered incorrect password.
                    Console.WriteLine("Your password is incorrect! please try again.");
                }

                break;

        }


    }
}