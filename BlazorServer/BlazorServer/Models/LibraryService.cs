using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class LibraryService : ILibraryService
    {
        private LibraryContext _context;
        public LibraryService(LibraryContext context)
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
