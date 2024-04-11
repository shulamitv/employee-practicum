using Employee.Core.Models;
using Employee.Core.Repositories;
using Employee.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Service
{
    public class RoleService: IRoleService
    {
        private readonly IRoleRepository _RoleRepository;
        public RoleService(IRoleRepository RoleRepository)
        {
            _RoleRepository = RoleRepository;
        }
        public async Task<IEnumerable<RoleD>> GetRolesAsync()
        {
            return await _RoleRepository.GetRolesAsync();
        }
        public async Task<RoleD> GetRoleAsync(int id)
        {
            return await _RoleRepository.GetRoleAsync(id);
        }
        public async Task<RoleD> AddRoleAsync(RoleD role)
        {
            return await _RoleRepository.AddRoleAsync(role);
        }
        public async Task<RoleD> UpdateRoleAsync(int id, RoleD role)
        {
            return await _RoleRepository.UpdateRoleAsync(id, role);
        }
        public async Task DeleteRoleAsync(int id)
        {
            _RoleRepository.DeleteRoleAsync(id);
        }
    }
}
