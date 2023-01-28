using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityModels
{
    public class EmployeeDto
    {
        private bool isManager;
        private string fullName;
        public string? FullName {
            get
            {
                return fullName;
            }
            set
            {
                fullName = string.Format($"{Firstname} {LastName}");
            }
        }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager
        {
            get
            {
                return isManager;
            }
            set
            {
                isManager = value;
            }
        }
    }
}
