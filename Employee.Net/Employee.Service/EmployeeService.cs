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
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<IEnumerable<EmployeeD>> GetEmployeesAsync()
        {
            return await _employeeRepository.GetEmployeesAsync();
        }
        public async Task<EmployeeD> GetEmployeeAsync(int id)
        {
            return await _employeeRepository.GetEmployeeAsync(id);
        }
        public async Task<EmployeeD> AddEmployeeAsync(EmployeeD employee)
        {

            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "Employee cannot be null.");
            }

            var properties = typeof(EmployeeD).GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(employee);

                if (value == null)
                {
                    throw new ArgumentException($"{property.Name} is required.", property.Name);
                }
            }

            return  await _employeeRepository.AddEmployeeAsync(employee);
        }
        public async Task<EmployeeD> UpdateEmployeeAsync(int id, EmployeeD employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "Employee cannot be null.");
            }

            var properties = typeof(EmployeeD).GetProperties();

            foreach (var property in properties)
            {
                var value = property.GetValue(employee);

                if (value == null)
                {
                    throw new ArgumentException($"{property.Name} is required.", property.Name);
                }
            }

            return await _employeeRepository.UpdateEmployeeAsync(id, employee);
        }
        public async Task DeleteEmployeeAsync(int id)
        {
           await  _employeeRepository.DeleteEmployeeAsync(id);
        }
    }
}

