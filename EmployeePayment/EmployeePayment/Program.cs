using EmployeePayment.Entities;
using System;
using System.Collections.Generic;

namespace EmployeePayment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees");
            int numberOfEmployee = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();
            
            for(int i = 0; i < numberOfEmployee; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data: ");

                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourced == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS");
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - ${employee.Payment()}");
            }
        }
    }
}
