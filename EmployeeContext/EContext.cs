using cascadind_dropdown.Models;
using Microsoft.EntityFrameworkCore;

namespace cascadind_dropdown.EmployeeContext
{
    public class EContext:DbContext
    {
        public EContext(DbContextOptions opt):base(opt)
        {
            
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Designation> designation {get; set;}
        public DbSet<Grade> grades { get; set; }
    }   
}
