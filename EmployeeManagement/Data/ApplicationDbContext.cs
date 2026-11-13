using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Department> Departments => Set<Department>();
    public DbSet<Employee> Employees => Set<Employee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>().HasData(
            new Department { Id = 1, Name = "技术部", Description = "负责产品研发与技术支持" },
            new Department { Id = 2, Name = "市场部", Description = "负责市场推广与客户关系" },
            new Department { Id = 3, Name = "人事部", Description = "负责人员招聘与组织管理" });

        modelBuilder.Entity<Employee>().HasData(
            new Employee { Id = 1, Name = "张伟", EmployeeNumber = "E001", Position = "高级工程师", HireDate = new DateTime(2021, 5, 10), IsActive = true, DepartmentId = 1 },
            new Employee { Id = 2, Name = "李娜", EmployeeNumber = "E002", Position = "市场经理", HireDate = new DateTime(2022, 3, 15), IsActive = true, DepartmentId = 2 },
            new Employee { Id = 3, Name = "王强", EmployeeNumber = "E003", Position = "招聘专员", HireDate = new DateTime(2023, 8, 1), IsActive = true, DepartmentId = 3 });
    }
}
