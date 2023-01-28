using CoreLayer.Entity;
using EntityModels.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels.Data
{
    public static class SeedData
    {
        public static List<Employee> Employees()
        {
            List<Employee> list = new List<Employee>()
           {
               new Employee() { Id= 1 , DepartmentId=1, Firstname="Bob", AnnualSalary=6000.3m, IsManager=true, Lastname="Jones"},
               new Employee() { Id= 2 , DepartmentId=2, Firstname="Sarah", AnnualSalary=3000.3m, IsManager=false, Lastname="James"},
               new Employee() { Id= 3 , DepartmentId=3, Firstname="Lee", AnnualSalary=2000.3m, IsManager=false, Lastname="Rekson"},
               new Employee() { Id= 4 , DepartmentId=4, Firstname="Troy", AnnualSalary=8000.3m, IsManager=false, Lastname="Jekson"},
               new Employee() { Id= 5 , DepartmentId=1, Firstname="Duglas", AnnualSalary=1000.3m, IsManager=true, Lastname="Lopez"},
               new Employee() { Id= 6 , DepartmentId=2, Firstname="Namiq", AnnualSalary=3500.3m, IsManager=true, Lastname="Humana"},
               new Employee() { Id= 7 , DepartmentId=2, Firstname="Ramil", AnnualSalary=5000.3m, IsManager=false, Lastname="Jones"},
               new Employee() { Id= 8 , DepartmentId=3, Firstname="Robert", AnnualSalary=2030.3m, IsManager=false, Lastname="Jones"},
               new Employee() { Id= 9 , DepartmentId=1, Firstname="Fidan", AnnualSalary=8020.3m, IsManager=true, Lastname="Jones"},
           };
            return list;
        }
        public static List<Department> Departments()
        {
            List<Department> list = new List<Department>()
            {
                new Department() { Id= 1 , ShortName="FN", LongName="Finance"},
                new Department() { Id= 2 , ShortName="TE", LongName="Technology"},
                new Department() { Id= 3 , ShortName="HR", LongName="Human Resources"},
                new Department() { Id= 4 , ShortName="AC", LongName="Account"},
            };
            return list;
        }
    }
}
