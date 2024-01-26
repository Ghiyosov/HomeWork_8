using Domain.Models;
namespace Infrastructure.Service;

public class DepartmentService
{
      private List<Department> _department;

    public DepartmentService()
    {
        _department = new List<Department>();
    }

    public List<Department> GetDepartment()
    {
        return _department;
    }
    public Department GetDepartmentById(int id)
    {
        foreach (var department in _department)
        {
            if (department.Id == id) return department;
        }

        return null;
    }
    public void AddDepartment(Department department)
    {
        if (department.Id == null)
        {
            department.Id = _department.Count + 1;
        }
        _department.Add(department);
    }
    public int CountDepartment()
    {
        return _department.Count;
    }
    public Department Update(Department department)
    {
        foreach (var e in _department)
        {
            if (e.Id == department.Id)
            {
                e.Name = department.Name;
                e.Description = department.Description;
                e.Manager = department.Manager;
              

            }
            return e;
            
        }
        return department;
    }
    public void DeleteEmployee(int id)
    {
        foreach (var em in _department)
        {
            if (em.Id == id) _department.Remove(em); 
        }
    }


}
