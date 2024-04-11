using Employee.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeD>> GetEmployeesAsync();
        Task<EmployeeD> GetEmployeeAsync(int id);
        Task<EmployeeD> AddEmployeeAsync(EmployeeD employee);
        Task<EmployeeD> UpdateEmployeeAsync(int id, EmployeeD employee);
        Task DeleteEmployeeAsync(int id);
    }
}
