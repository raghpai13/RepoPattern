using System.ComponentModel.DataAnnotations;

namespace RepoPatternAPI.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department {  get; set; }
    }
}
