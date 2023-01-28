// See https://aka.ms/new-console-template for more information
using BusinessLayer;
using EntityModels;
using EntityModels.Concrete;
using EntityModels.Data;

var empList = SeedData.Employees();
var depList = SeedData.Departments();

//Select and where Operators -Method Syntax
//With Anonomys Type
//var result = SeedData.Employees().Select(x => new
//{
//    FullName = x.Firstname + " " + x.Lastname,
//    IsManager = x.IsManager,
//    AnnualSalary = x.AnnualSalary
//});

//With DTO
//var result2 = SeedData.Employees().Select(x => new EmployeeDto()
//{
//    AnnualSalary = x.AnnualSalary,
//    Firstname = x.Firstname,
//    FullName = x.Lastname,
//    IsManager = x.IsManager,
//}).Where(c => c.IsManager);

//var result2 = empList.Where(x=>x.AnnualSalary > 50000).Select(x => new EmployeeDto()
//{
//    AnnualSalary = x.AnnualSalary,
//    Firstname = x.Firstname,
//    LastName = x.Lastname,
//    IsManager = x.IsManager,
//});

//var result3 = from emp in empList
//              where emp.AnnualSalary > 50000
//              select new
//              {
//                  FullName = emp.Firstname + " " + emp.Lastname,
//                  Manager = emp.IsManager ? "Yes" : "No",
//                  Salary = emp.AnnualSalary
//              };

//foreach (var item in result)
//{
//    Console.WriteLine($"Full Name: {item.FullName} IsManager: {item.IsManager} Salary: {item.AnnualSalary}");
//}
empList.Add(new Employee() { Id = 10, Firstname = "Adil", DepartmentId = 1, Lastname = "Ahmadov", AnnualSalary = 60000, IsManager = true });
//foreach (var item in result2)
//{
//    var manager = item.IsManager ? "Yes" : "No";
//    Console.WriteLine($"Full Name: {item.FullName,-10} IsManager: {manager,-10} Salary: {item.AnnualSalary,-10}");
//}

var result4 = from emp in empList.GetHighSalariedEmployees(50000)
              select new
              {
                  FullName = emp.Firstname + " " + emp.Lastname,
                  Salary = emp.AnnualSalary
              };
foreach (var item in result4)
{
    Console.WriteLine(item.Salary);
}
Console.WriteLine();

//foreach (var item in result3)
//{
//    Console.WriteLine($"Full Name: {item.FullName,-20} IsManager: {item.Manager,-10} Salary: {item.Salary,-10}");
//}


Console.ReadLine();