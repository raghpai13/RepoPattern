using Microsoft.EntityFrameworkCore;
using RepoPatternAPI.Data;
using RepoPatternAPI.Models;


namespace RepoPatternAPI.Repository
{
    public class MockEmployeeRepo : IEmployeeRepo
    {
        private EmployeDbContext _dbContext;
        public MockEmployeeRepo(EmployeDbContext dbContext) { 
        
            _dbContext = dbContext;
        }
        public void Add(EmployeeDto employee)
        {
                _dbContext.EmployeData.Add(employee);
                _dbContext.SaveChanges();
            
        }

        public void Delete(int id)
        {
            var Emp = _dbContext.EmployeData.Find(id);
            if (Emp != null)
            {
                _dbContext.EmployeData.Remove(Emp);
            }
            _dbContext.SaveChanges();
        }

        public List<EmployeeDto> GetAllEmployee()
        {
            return _dbContext.EmployeData.ToList();
        }

        public EmployeeDto GetEmployee(int id)
        {
            var Emp = _dbContext.EmployeData.Find(id);
            return Emp;
        }

        public void Update(EmployeeDto employee)
        {
            _dbContext.EmployeData.Update(employee);
            _dbContext.SaveChanges();
        }
    }

}
