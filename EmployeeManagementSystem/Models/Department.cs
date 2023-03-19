using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        public string Dept_Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Department()
        {

        }

        public Department(int dept_Id, string dept_Name)
        {
            Dept_Id = dept_Id;
            Dept_Name = dept_Name;
        }
    }
}
