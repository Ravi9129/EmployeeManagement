using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;

namespace EmployeeManagement.Data
{
    public class EmpData : DbContext
    {
        public EmpData(DbContextOptions<EmpData> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
