using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        public string EmpId { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [Required, EmailAddress]
        public string EmailId { get; set; }

        [Required]
        public string MobileNumber { get; set; }

        public string Department { get; set; }
        public string Designation { get; set; }

        public decimal MonthlySalary { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string State { get; set; }

        public string Pincode { get; set; }
    }

}
