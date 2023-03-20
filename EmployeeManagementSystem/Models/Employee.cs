using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public DateTime Emp_DOB { get; set; }
        [EmailAddress]
        public string Emp_Email { get; set; }
        [Phone]
        public long Emp_Phone { get; set; }
        [ForeignKey("Department")]
        public int Dep_Id { get; set; }
        public Department Department { get; set; }

        public Employee()
        {

        }

        public Employee(int emp_Id, string emp_Name, DateTime emp_DOB, string emp_Email, long emp_Phone, int dep_Id)
        {
            Emp_Id = emp_Id;
            Emp_Name = emp_Name;
            Emp_DOB = emp_DOB;
            Emp_Email = emp_Email;
            Emp_Phone = emp_Phone;
            Dep_Id = dep_Id;

        }
    }
}
