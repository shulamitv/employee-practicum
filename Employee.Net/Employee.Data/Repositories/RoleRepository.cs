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
    public class RoleRepository : IRoleRepository
    {
        public readonly DataContext _context;
        public RoleRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<RoleD>> GetRolesAsync()
        {
            return await _context.Roles.Include(u => u.RolesForEmployees).ToListAsync();
        }
        public async Task<RoleD> GetRoleAsync(int id)
        {
            return await _context.Roles.FirstAsync(u => u.Id == id);
        }
        public async Task<RoleD> AddRoleAsync(RoleD role)
        {
            _context.Roles.Add(role);
            await _context.SaveChangesAsync();
            return role;
        }
        public async Task<RoleD> UpdateRoleAsync(int id, RoleD role)
        {
            var updateRole = await GetRoleAsync(id);
            return updateRole;

        }
        public async Task DeleteRoleAsync(int id)
        {
            var role = await GetRoleAsync(id);
            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
        }
    }
}
