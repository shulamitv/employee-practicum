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
    public class RoleForEmployeeRepository : IRoleForEmployeeRepository
    {

        public readonly DataContext _context;
        public RoleForEmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<RoleForEmployeeD>> GetRolesForEmployeeAsync()
        {
            return await _context.RolesForEmployees.ToListAsync();
        }
        public async Task<RoleForEmployeeD> GetRoleForEmployeeAsync(int id)
        {

            return await _context.RolesForEmployees.FirstAsync(u => u.Id == id);
        }
        public async Task<RoleForEmployeeD> AddRoleForEmployeeAsync(RoleForEmployeeD roleForEmployee)
        {
            _context.RolesForEmployees.Add(roleForEmployee);
            await _context.SaveChangesAsync();
            return roleForEmployee;
        }
        public async Task<RoleForEmployeeD> UpdateRoleForEmployeeAsync(int id, RoleForEmployeeD roleForEmployee)
        {
            var updateRoleForEmployee = await GetRoleForEmployeeAsync(id);
            await _context.SaveChangesAsync();
            return updateRoleForEmployee;
        }
        public async Task DeleteRoleForEmployeeAsync(int id)
        {
            var roleToDelete = await GetRoleForEmployeeAsync(id);
            roleToDelete.Status = false;
            await _context.SaveChangesAsync();
        }
    }
}
