using CoreLayer.Entity;

namespace EntityModels.Concrete
{
    public class Employee:IEntity
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public decimal AnnualSalary { get; set; }
        public bool IsManager { get; set; }
        public int DepartmentId { get; set; }
    }
}
