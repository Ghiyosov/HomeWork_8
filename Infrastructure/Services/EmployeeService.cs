using Domain.Models;



namespace Infrastructure.Service;
 

public class EmployeeService
{
    private List<Employee> _employees;

    public EmployeeService()
    {
        _employees = new List<Employee>();
    }

    public List<Employee> GetEmployees()
    {
        return _employees;
    }
    public Employee GetEmployeeById(int id)
    {
        foreach (var empl in _employees)
        {
            if (empl.Id == id) return empl;
        }

        return null;
    }
    public void AddEmployee(Employee employee)
    {
        if (employee.Id == null)
        {
            employee.Id = _employees.Count + 1;
        }
        _employees.Add(employee);
    }
    public int CountEmployee()
    {
        return _employees.Count;
    }
    public Employee Update(Employee employee)
    {
        foreach (var e in _employees)
        {
            if (e.Id == employee.Id)
            {
                e.Firstname = employee.Firstname;
                e.Lastname = employee.Lastname;
                e.Salary = employee.Salary;
                e.BirthDate = employee.BirthDate;

            }
            return e;
            
        }
        return employee;
    }
    public void DeleteEmployee(int id)
    {
        foreach (var em in _employees)
        {
            if (em.Id == id) _employees.Remove(em); 
        }
    }

}
