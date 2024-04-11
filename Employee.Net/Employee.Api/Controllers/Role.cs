using AutoMapper;
using Employee.Api.Models;
using Employee.Core.DTOs;
using Employee.Core.Models;
using Employee.Core.Service;
using Employee.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Role : ControllerBase
    {
        private IRoleService _roleService;
        private IMapper _mapper;
        public Role(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        // GET: api/<Role>
        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            var list = await _roleService.GetRolesAsync();
            var listDto = _mapper.Map<IEnumerable<RoleDTO>>(list);
            return Ok(listDto);
        }
 

        // GET api/<Role>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var role = await _roleService.GetRoleAsync(id);
            var roleDto=_mapper.Map<RoleDTO>(role);
            return Ok(roleDto);
        }

        // POST api/<Role>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] RolePostModel role)
        {
            var roleToPost = new RoleD() { Id = role.Id, RoleName = role.RoleName};
            var result = await _roleService.AddRoleAsync(roleToPost);
            return Ok(result);
        }

        // PUT api/<Role>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] RolePostModel role)
        {
            var roleToPut = new RoleD() { Id = role.Id, RoleName = role.RoleName};
            var result = await _roleService.UpdateRoleAsync(id, roleToPut);
            return Ok(result);
        }

        // DELETE api/<Role>/5
        [HttpDelete("{id}")]
        public async Task DeleteAsync(int id)
        {
           await _roleService.DeleteRoleAsync(id);

        }
    }
}
