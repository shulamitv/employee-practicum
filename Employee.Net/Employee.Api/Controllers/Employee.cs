using AutoMapper;
using Employee.Api.Models;
using Employee.Core.DTOs;
using Employee.Core.Models;
using Employee.Core.Service;
using Employee.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using System.Security.Cryptography.Xml;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee : ControllerBase
    {
        private IEmployeeService _employeeService;
        private IMapper _mapper;
        public Employee(IEmployeeService employeeService,IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }

        // GET: api/<Employee>
        //[Authorize]
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var list = await _employeeService.GetEmployeesAsync();
            var listDto=_mapper.Map<IEnumerable<EmployeeDTO>>(list);
            return Ok(listDto);
        }

        // GET api/<Employee>/5
        //[Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var employee = await _employeeService.GetEmployeeAsync(id);
            var employeDto=_mapper.Map<EmployeeDTO>(employee);
            return Ok(employeDto);
        }

        // POST api/<Employee>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] EmployeePostModel employee)
        {
            var roles = new List<RoleForEmployeeD>();
            for (int i = 0; i < employee.RolesForEmployees.Count(); i++)
            {
                roles.Add(new RoleForEmployeeD()
                {
                    RoleDId = employee.RolesForEmployees[i].RoleDId,
                    RoleName = employee.RolesForEmployees[i].RoleName,
                    EntryDate =employee.RolesForEmployees[i].EntryDate,
                    IsManagerial = employee.RolesForEmployees[i].IsManagerial,
                });
            }

            var employeeToPost = new EmployeeD() { Id = employee.Id, FirstName = employee.FirstName, LastName = employee.LastName, StartDate = employee.StartDate, Status = employee.Status, RolesForEmployees = roles };
            var result = await _employeeService.AddEmployeeAsync(employeeToPost);
            return Ok(result);
        }

        // PUT api/<Employee>/5
        [HttpPut("put/{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] EmployeePostModel employee)
        {
            var roles = new List<RoleForEmployeeD>();
            for (int i = 0; i < employee.RolesForEmployees.Count(); i++)
            {
                roles.Add(new RoleForEmployeeD()
                {
                    RoleDId = employee.RolesForEmployees[i].RoleDId,
                    RoleName = employee.RolesForEmployees[i].RoleName,
                    EntryDate = employee.RolesForEmployees[i].EntryDate,
                    IsManagerial = employee.RolesForEmployees[i].IsManagerial

                }) ;
            }
            var employeeToPut = new EmployeeD() { Id = employee.Id, FirstName = employee.FirstName, LastName = employee.LastName, StartDate = employee.StartDate, Status = employee.Status, RolesForEmployees=roles };
            var result = await _employeeService.UpdateEmployeeAsync(id, employeeToPut);
            return Ok(result);

        }

        // DELETE api/<Employee>/5
        
        [HttpDelete("delete/{id}")]

        public async Task DeleteAsync(int id)
        {
            await _employeeService.DeleteEmployeeAsync(id);
        }
    }
}
