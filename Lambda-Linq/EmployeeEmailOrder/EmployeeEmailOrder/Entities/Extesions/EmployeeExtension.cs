

namespace EmployeeEmailOrder.Entities.Extesions
{
    static class EmployeeExtension
    {
        public static string EmployeeText(this Employee employee)
        {
            return employee.Name + ", " + employee.Email + ", " + employee.Salary;
        }
    }
}
