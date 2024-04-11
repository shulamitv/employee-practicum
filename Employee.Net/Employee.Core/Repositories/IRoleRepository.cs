using Employee.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{
    public interface IRoleRepository
    {
        Task<IEnumerable<RoleD>> GetRolesAsync();
        Task<RoleD> GetRoleAsync(int id);
        Task<RoleD> AddRoleAsync(RoleD role);
        Task<RoleD> UpdateRoleAsync(int id, RoleD role);
        Task DeleteRoleAsync(int id);
    }
}
