using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models;

public class Employee
{
    public int Id { get; set; }

    [Required, StringLength(30)]
    [Display(Name = "姓名")]
    public string Name { get; set; } = string.Empty;

    [Required, StringLength(20)]
    [Display(Name = "工号")]
    public string EmployeeNumber { get; set; } = string.Empty;

    [StringLength(50)]
    [Display(Name = "职位")]
    public string? Position { get; set; }

    [DataType(DataType.Date)]
    [Display(Name = "入职日期")]
    public DateTime HireDate { get; set; } = DateTime.Today;

    [Display(Name = "在职")]
    public bool IsActive { get; set; } = true;

    [Display(Name = "部门")]
    public int DepartmentId { get; set; }

    public Department? Department { get; set; }
}
