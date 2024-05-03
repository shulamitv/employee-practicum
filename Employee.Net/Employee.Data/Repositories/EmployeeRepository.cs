using Employee.Core.Models;
using Employee.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Employee.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<EmployeeD>> GetEmployeesAsync()
        {
            return await _context.Employees.Include(u => u.RolesForEmployees).ToListAsync();
        }
        public async Task<EmployeeD> GetEmployeeAsync(int id)
        {
            return await _context.Employees.Include(u => u.RolesForEmployees).FirstAsync(u => u.Id == id&&u.Status==true);
        }
        public async Task<EmployeeD> AddEmployeeAsync(EmployeeD employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return employee;
        }
        public async Task<EmployeeD> UpdateEmployeeAsync(int id, EmployeeD employee)
        {
            var employeeToUpdate = await GetEmployeeAsync(employee.Id);
            employeeToUpdate.FirstName = employee.FirstName;
            employeeToUpdate.LastName = employee.LastName;
            employeeToUpdate.StartDate = employee.StartDate;
            employeeToUpdate.Status = employee.Status;
            employeeToUpdate.RolesForEmployees = employee.RolesForEmployees;
            await _context.SaveChangesAsync();
            return employeeToUpdate;
        }
        public async Task DeleteEmployeeAsync(int id)
        {
            var employeeToDelete = await GetEmployeeAsync(id);
            employeeToDelete.Status = false;
            await _context.SaveChangesAsync();
        }

    }
}
