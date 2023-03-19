using EmployeeManagementSystem.Models;
using EMSApp.Repository;

namespace EmployeeManagementSystem.Repository.InMemory
{
    public class DepartmentInMemoryRepository : IDepartmentRepository
    {
        static List<Department> departmentList = new List<Department>();

        static DepartmentInMemoryRepository()
        {
            departmentList.Add(new Department(1, "HR"));
            departmentList.Add(new Department(1, "Marketing"));
            departmentList.Add(new Department(1, "Engineering"));
        }
        public List<Department> GetAllDepartments()
        {
            return departmentList;   
        }

        public Department GetDepartmentById(int Id)
        {
            return departmentList.FirstOrDefault(x => x.Dept_Id == Id);
        }
        public Department AddDepartment(Department newDepartment)
        {
            newDepartment.Dept_Id = departmentList.Max(x => x.Dept_Id) + 1;
            departmentList.Add(newDepartment);
            return newDepartment;
        }

        public Department DeleteDepartment(int departmentId)
        {
            var oldDept = departmentList.Find(x => x.Dept_Id == departmentId);
            if (oldDept == null)
                return null;
            departmentList.Remove(oldDept);
            return oldDept;
        }

        public Department UpdateDepartment(int departmentId, Department newDepartment)
        {
            var oldDept = departmentList.Find(x => x.Dept_Id == departmentId);
            if (oldDept == null)
                return null;
            departmentList.Remove(oldDept);
            departmentList.Add(newDepartment);
            return newDepartment;
        }
    }
}
