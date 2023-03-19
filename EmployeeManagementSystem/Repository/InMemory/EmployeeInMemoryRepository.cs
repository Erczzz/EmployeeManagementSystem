using EmployeeManagementSystem.Models;
using EMSApp.Repository;

namespace EmployeeManagementSystem.Repository.InMemory
{
    public class EmployeeInMemoryRepository : IEmployeeRepository
    {
        static List<Employee> employeeList = new List<Employee>();

        static EmployeeInMemoryRepository()
        {
            employeeList.Add(new Employee(1, "Erica Barrientos", DateTime.Now.AddYears(-25),
                "ercz@gmail.com", 09123456789, 1));
            employeeList.Add(new Employee(1, "Ercz Barrientos", DateTime.Now.AddYears(-20),
                "ercz@gmail.com", 09123456789, 2));
            employeeList.Add(new Employee(1, "Ercz Barrie", DateTime.Now.AddYears(-22),
                "ercz@gmail.com", 09123456789, 2));
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeList;
        }
        public Employee GetEmployeeById(int Id)
        {
            return employeeList.FirstOrDefault(x => x.Emp_Id == Id);
        }
        public Employee AddEmployee(Employee newEmployee)
        {
            newEmployee.Emp_Id = employeeList.Max(x => x.Emp_Id) + 1;
            employeeList.Add(newEmployee);
            return newEmployee;

        }

        public Employee DeleteEmployee(int employeeId)
        {
            var oldEmployee = employeeList.Find(x => x.Emp_Id == employeeId);
            if (oldEmployee == null)
                return null;
            employeeList.Remove(oldEmployee);
            return oldEmployee;
        }

        public Employee UpdateEmployee(int employeeId, Employee newEmployee)
        {
            var oldEmployee = employeeList.Find(x => x.Emp_Id == employeeId);
            if (oldEmployee == null)
                return null;
            employeeList.Remove(oldEmployee);
            employeeList.Add(newEmployee);
            return newEmployee;
        }
    }
}
