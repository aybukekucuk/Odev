namespace BlazorWeb.Server.Models
{
    public interface INorthwindService
    {
        IEnumerable<Employee> GetEmployees();
        void InsertEmployee(Employee employee);
        void UpdateEmployee(long id, Employee employee);
        Employee SingleEmployee(long id);
        void DeleteEmployee(long id);
    }
}
