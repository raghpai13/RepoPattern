using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepoPatternAPI.Models;
using RepoPatternAPI.Repository;

namespace RepoPatternAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeRepo _repository;
        public EmployeeController(IEmployeeRepo repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult AddEmployee([FromForm] EmployeeDto employee)
        {
            _repository.Add(employee);
            return Ok(employee);
        }

        [HttpPut]
        public IActionResult UpdateEmployee([FromForm] EmployeeDto employee)
        {
            _repository.Update(employee);
            return Ok(employee);
        }

        [HttpGet()]
        public IActionResult GetEmployee()
        {
            var emp = _repository.GetAllEmployee();
            return Ok(emp);
        }

        [HttpGet("{id}")]
        public IActionResult GetId(int id)
        {
            var emp = _repository.GetEmployee(id);
            return Ok(emp);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
