using EmployeeManagement.Api.NewFolder2;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            this._roleService = roleService;
        }
    
        // GET: api/<RoleController>
        [HttpGet]
        public async Task<IEnumerable<Role>> Get()
        {
            return await _roleService.GetAllAsync();
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public async Task<Role> Get(int id)
        {
            return await _roleService.GetByIdAsync(id);
        }

        // POST api/<RoleController>
        [HttpPost]
        public async Task Post([FromBody] RolePostModel value)
        {

         var roleToAdd= new Role() { RoleName=value.RoleName};
                await   _roleService.AddRoleAsync(roleToAdd);
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] RolePostModel value)
        {
            var roleToEdit = new Role() {RoleName = value.RoleName};
            await _roleService.UpdateRoleAsync(id, roleToEdit);
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _roleService.DeleteRoleASync(id);
        }
    }
}
