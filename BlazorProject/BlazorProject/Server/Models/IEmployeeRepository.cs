using BlazorProject.Shared;

namespace BlazorProject.Server.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employees>> Search(string firstName, string lastName);
        Task<IEnumerable<Employees>> GetEmployees();
        Task<Employees> GetEmployee(int employeeId);
        Task<Employees> AddEmployee(Employees employee);
        Task<Employees> UpdateEmployee(Employees employee);
        Task DeleteEmployee(int employeeId);
    }
}
