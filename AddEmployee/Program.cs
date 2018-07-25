using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AddEmployee
{
    class Program
    {
        public delegate List<Employee> NewEmployeeList();

        public static List<Employee> CreateNewEmployeeList()
        {
            return (new List<Employee>());
        }
        static void Main(string[] args)
        {
            int choice, employeeID, numberOfEmployee=0;
            string qualification;
            NewEmployeeList createList = new NewEmployeeList(CreateNewEmployeeList);
            List<Employee> employees = createList();
            try
            {
                while (true)
                {
                    Console.WriteLine("\n\n------CHOICE MENU------");
                    Console.WriteLine("1. ADD EMPLOYEE");
                    Console.WriteLine("2. EXIT FROM HERE");
                    Console.WriteLine("\nENTER YOUR CHOICE:");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("ENTER THE EMPLOYEE ID:");
                            employeeID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("ENTER THE EMPLOYEE'S QUALIFICATION: ");
                            qualification = Console.ReadLine();
                            employees.Add(new Employee(employeeID, qualification));
                            numberOfEmployee++;
                            break;
                        case 2:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("\n\n\n-------------WARNING-------------");
                            Console.WriteLine("INVALID CHOICE ENTERED. TRY AGAIN\n\n\n");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                using (StreamWriter sr = File.AppendText(@"D:\AddEmployeeExceptionLog.txt"))
                {
                    sr.WriteLine(e.ToString());
                }
                Console.WriteLine(e);
                Console.ReadKey();
            }
            finally
            {
                System.Environment.Exit(0);
            }

        }
    }
}
