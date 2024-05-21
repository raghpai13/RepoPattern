using RepoPatternAPI.Models;

namespace RepoPatternAPI.Repository
{
    public interface IEmployeeRepo
    {
        EmployeeDto GetEmployee(int id);
        List<EmployeeDto> GetAllEmployee();
        void Add(EmployeeDto employee);
        void Update(EmployeeDto employee);
       void Delete(int id);

    }
}
