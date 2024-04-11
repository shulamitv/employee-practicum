using Employee.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Service
{
    public interface IRoleForEmployeeService
    {
        Task<IEnumerable<RoleForEmployeeD>> GetRolesForEmployeeAsync();
        Task<RoleForEmployeeD> GetRoleForEmployeeAsync(int id);
        Task<RoleForEmployeeD> AddRoleForEmployeeAsync(RoleForEmployeeD roleForEmployee);
        Task<RoleForEmployeeD> UpdateRoleForEmployeeAsync(int id, RoleForEmployeeD roleForEmployee);
        Task DeleteRoleForEmployeeAsync(int id);
    }
}
