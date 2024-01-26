


using Infrastructure.Service;
using Domain.Models;

var employeeService = new EmployeeService();
System.Console.WriteLine(employeeService.CountEmployee());

var emp1 = new Employee()
{
    Id = 1,
    Firstname = "Abdulloh1",
    Lastname = "Abdulloev1",
    BirthDate = new DateTime(1990,02,02),
    Salary = 1245m,
};
employeeService.AddEmployee(emp1);
System.Console.WriteLine(employeeService.CountEmployee());
var emp2 = new Employee()
{
    Id = 2,
    Firstname = "Abdulloh2",
    Lastname = "Abdulloev2",
    BirthDate = new DateTime(1990,02,02),
    Salary = 1245m,
};
employeeService.AddEmployee(emp2);
System.Console.WriteLine(employeeService.CountEmployee());
var emp3 = new Employee()
{
    Id = 98,
    Firstname = "Abdulloh3",
    Lastname = "Abdulloev3",
    BirthDate = new DateTime(1990,02,02),
    Salary = 1245m,
};
employeeService.AddEmployee(emp3);
System.Console.WriteLine(employeeService.CountEmployee());

System.Console.WriteLine("***********************************");
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine( emp3.Id);
System.Console.WriteLine("***********************************");
System.Console.WriteLine();
System.Console.WriteLine();
var b = employeeService.GetEmployeeById(98);
 System.Console.WriteLine($"FirstName : {b.Firstname}");
 b.Salary = 1200m;
 System.Console.WriteLine($"Salary : {b.Salary}");
var emp4 = new Employee()
{
    Id = 98,
    Firstname = "Abdulloh35",
    Lastname = "Abdulloev35",
    BirthDate = new DateTime(1990,02,02),
    Salary = 1845m,
};
employeeService.Update(emp4);
var c = employeeService.GetEmployeeById(98);
 System.Console.WriteLine($"FirstName : {c.Firstname}");
 System.Console.WriteLine($"Salary : {c.Salary}");
 
