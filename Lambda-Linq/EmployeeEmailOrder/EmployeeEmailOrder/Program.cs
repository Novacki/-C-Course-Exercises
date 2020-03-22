using EmployeeEmailOrder.Entities;
using EmployeeEmailOrder.Entities.Extesions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace EmployeeEmailOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\fernando.freitas\Desktop\Estágio - Estudos\C#\-C-Course-Exercises\Lambda-Linq\EmployeeEmailOrder\EmployeeEmailOrder\Repository\Data\employees.txt";
            List<Employee> employees = new List<Employee>();
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] employee = sr.ReadLine().Split(",");

                    string name = employee[0];
                    string email = employee[1];
                    double salary = double.Parse(employee[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            };

            Console.Write("Value Order: ");
            double value = double.Parse(Console.ReadLine());

            IEnumerable<Employee> resultOrderEmail = employees
                .Where(s => s.Salary > value)
                .OrderBy(n => n.Email)
                .Select(s => s);

            //Console.WriteLine(employees); Perguntar

            Console.WriteLine();
            foreach(Employee emp in resultOrderEmail)
            {
                Console.WriteLine(emp.EmployeeText());
                Console.WriteLine();
            }

            double sumSalary = employees.Where(s => s.Name[0] == 'M').Select(s => s.Salary).Sum(a => a);
            Console.WriteLine("Sum Salary: " + sumSalary);
        }
    }
}
