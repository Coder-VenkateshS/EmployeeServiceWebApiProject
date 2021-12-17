using Microsoft.EntityFrameworkCore;
namespace EmployeeService.Data
{
public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base
        {}
        public DbSet<EmployeeService.Models.Employee> Employee { get; set;}
    }
}