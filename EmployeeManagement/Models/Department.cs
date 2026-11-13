using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models;

public class Department
{
    public int Id { get; set; }

    [Required, StringLength(50)]
    [Display(Name = "部门名称")]
    public string Name { get; set; } = string.Empty;

    [StringLength(200)]
    [Display(Name = "部门描述")]
    public string? Description { get; set; }

    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
