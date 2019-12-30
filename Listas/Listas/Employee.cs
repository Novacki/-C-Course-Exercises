using System;
using System.Collections.Generic;

namespace Listas {
    class Employee {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee() { }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;

            if(Salary < 998.00) {
                Salary = 998.00;
            }
        }

        public void IncreaseSalary(double increase) {
            Salary += Salary * (increase / 100); 
        }

        public static void listEmployees(List<Employee> employees) {
            if(employees != null) {
                Console.WriteLine("Employee List: ");
                foreach(Employee employee in employees) {
                    Console.WriteLine(employee);
                }
            }
            else {
                Console.WriteLine("Empty Employee List");
            }
        }

        public override string ToString() {
            return "ID: " + Id +
                    " Name: " + Name +
                    " Salary: " + Salary.ToString("F2");
        }

    }
}
