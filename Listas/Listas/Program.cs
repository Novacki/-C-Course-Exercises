using System;
using System.Collections.Generic;

namespace Listas {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Type it amount Employees: ");
            int id, amount = int.Parse(Console.ReadLine());
            double salary;

            List<Employee> employees = new List<Employee>();

            while(employees.Count != amount) {
                Console.WriteLine("Type it the id of Employee: ");
                id = int.Parse(Console.ReadLine());

                Console.WriteLine("Type it the Name of Employee: ");
                string name = Console.ReadLine();

                Console.WriteLine("Type it the salary of Employee: ");
                salary = double.Parse(Console.ReadLine());

                Employee employee = new Employee(id, name, salary);
                employees.Add(employee);
            }

            Console.WriteLine();
            Console.WriteLine("Employee Registered");
            Employee.listEmployees(employees);
            Console.WriteLine();

            Console.WriteLine("Type it the ID you whant to update: ");
            id = int.Parse(Console.ReadLine());

            Employee update = employees.Find(epy => epy.Id == id);

            if(update == null) {
                Console.WriteLine("There is no such employee!!");
            }
            else {
                Console.WriteLine("Enter with salary update: ");
                salary = double.Parse(Console.ReadLine());

                update.IncreaseSalary(salary);
                Console.WriteLine("Update list of Employees ");
            }

            Console.WriteLine();
            Employee.listEmployees(employees);
        } 
    }
}
