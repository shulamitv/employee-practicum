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
    public class RoleForEmployeeService:IRoleForEmployeeService
    {

        //IEnumerable<RoleForEmployeeD> GetRolesForEmployee();
        //RoleForEmployeeD GetRoleForEmployee(int id);
        //RoleForEmployeeD AdRoleForEmployee(RoleForEmployeeD roleForEmployee);
        //RoleForEmployeeD UpdateRoleForEmployee(int id, RoleForEmployeeD roleForEmployee);
        //void DeleteRoleForEmployee(int id);
        private readonly IRoleForEmployeeRepository _roleForEmployeeRepository;
        public RoleForEmployeeService(IRoleForEmployeeRepository roleForEmployeeRepository)
        {
            _roleForEmployeeRepository = roleForEmployeeRepository;
        }
        public async Task<IEnumerable<RoleForEmployeeD>> GetRolesForEmployeeAsync()
        {
            return await _roleForEmployeeRepository.GetRolesForEmployeeAsync();
        }
        public async Task<RoleForEmployeeD> GetRoleForEmployeeAsync(int id)
        {
            return await _roleForEmployeeRepository.GetRoleForEmployeeAsync(id);
        }
        public async Task<RoleForEmployeeD> AddRoleForEmployeeAsync(RoleForEmployeeD roleForEmployee)
        {
            return await _roleForEmployeeRepository.AddRoleForEmployeeAsync(roleForEmployee);
        }
        public async Task<RoleForEmployeeD> UpdateRoleForEmployeeAsync(int id, RoleForEmployeeD roleForEmployee)
        {
            return await _roleForEmployeeRepository.UpdateRoleForEmployeeAsync(id, roleForEmployee);
        }
        public async Task DeleteRoleForEmployeeAsync(int id)
        {
            _roleForEmployeeRepository.DeleteRoleForEmployeeAsync(id);
        }
    }
}
