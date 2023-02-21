using BlazorProject.Shared;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorProject.Server.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<Employees> AddEmployee(Employees employee)
        {
            var result = await appDbContext.Employees.AddAsync(employee);
            await appDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var result = await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.EmployeeID == employeeId);

            if (result != null)
            {
                appDbContext.Employees.Remove(result);
                await appDbContext.SaveChangesAsync();
            }
        }

        public async Task<Employees> GetEmployee(int employeeId)
        {
            return await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.EmployeeID == employeeId);
        }

        public async Task<IEnumerable<Employees>> GetEmployees()
        {
            return await appDbContext.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Employees>> Search(string firstName, string lastName)
        {
            IQueryable<Employees> query = appDbContext.Employees;
            if (!string.IsNullOrEmpty(firstName))
            {
                query = query.Where(e => e.FirstName.Contains(firstName));
            }
            if (!string.IsNullOrEmpty(lastName))
            {
                query = query.Where(e => e.LastName.Contains(lastName));
            }
            return await query.ToListAsync();
        }

        public async Task<Employees> UpdateEmployee(Employees employee)
        {
            var result = await appDbContext.Employees
                .FirstOrDefaultAsync(e => e.EmployeeID == employee.EmployeeID);

            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Title = employee.Title;
                result.TitleOfCourtesy = employee.TitleOfCourtesy;
                result.BirthDate = employee.BirthDate;
                result.City = employee.City;
                result.Country = employee.Country;

                await appDbContext.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
