using Microsoft.EntityFrameworkCore;
using RepoPatternAPI.Models;

namespace RepoPatternAPI.Data
{
    //using base class Dbcontext
    public class EmployeDbContext: DbContext
    {
        public EmployeDbContext(DbContextOptions<EmployeDbContext>options):base(options) { 
        
        }
        public DbSet<EmployeeDto> EmployeData { get; set; }
    }
}
