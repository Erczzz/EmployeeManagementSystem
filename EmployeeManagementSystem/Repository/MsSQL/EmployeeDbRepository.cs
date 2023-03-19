using EmployeeManagementSystem.Models;
using EMSApp.Data;
using Microsoft.EntityFrameworkCore;

namespace EMSApp.Repository.MsSQL
{
    public class EmployeeDbRepository : IEmployeeRepository
    {
        EmployeeDbContext _dbContext;

        public EmployeeDbRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Employee AddEmployee(Employee newEmployee)
        {
            _dbContext.Add(newEmployee);
            _dbContext.SaveChanges();
            return newEmployee;
        }

        public Employee DeleteEmployee(int employeeId)
        {
            var employee = GetEmployeeById(employeeId);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            return _dbContext.Employees.AsNoTracking().ToList();
        }

        public Employee GetEmployeeById(int Id)
        {
            return _dbContext.Employees.AsNoTracking().ToList().FirstOrDefault(t => t.Emp_Id == Id);
        }

        public Employee UpdateEmployee(int employeeId, Employee newEmployee)
        {
            _dbContext.Employees.Update(newEmployee);
            _dbContext.SaveChanges();
            return newEmployee;
        }
    }
}
