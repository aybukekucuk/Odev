using Microsoft.EntityFrameworkCore;

namespace BlazorWeb.Server.Models
{
    public class NorthwindService : INorthwindService
    {
        private NorthwindContext _context;
        public NorthwindService(NorthwindContext context)
        {
            _context = context;
        }
        public void DeleteEmployee(long id)
        {
            {
                try
                {
                    Employee ord = _context.Employees.Find(id);
                    _context.Employees.Remove(ord);
                    _context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public IEnumerable<Employee> GetEmployees()
        {
            try
            {
                return _context.Employees.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void InsertEmployee(Employee employee)
        {
            {
                try
                {
                    _context.Employees.Add(employee);
                    _context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }
        public Employee SingleEmployee(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEmployee(long id, Employee employee)
        {
            try
            {
                var local = _context.Set<Employee>().Local.FirstOrDefault(entry => entry.EmployeeId.Equals(employee.EmployeeId));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(employee).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
