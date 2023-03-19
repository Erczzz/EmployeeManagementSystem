using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Repository
{
    public interface IDepartmentRepository
    {
        List<Department> GetAllDepartments();
        Department GetDepartmentById(int Id);
        Department AddDepartment(Department newDepartment);
        Department UpdateDepartment(int departmentId, Department newDepartment);
        Department DeleteDepartment(int departmentId);
    }
}
