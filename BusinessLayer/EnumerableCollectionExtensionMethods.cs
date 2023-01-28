using EntityModels.Concrete;

namespace BusinessLayer
{
    public static class EnumerableCollectionExtensionMethods
    {
        public static IEnumerable<Employee> GetHighSalariedEmployees(this IEnumerable<Employee> employees, decimal salary)
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"Accessing employee: {emp.Firstname+ " "+ emp.Lastname}");
                if (emp.AnnualSalary >= salary)
                    yield return emp;
            }
        }
    }
}
