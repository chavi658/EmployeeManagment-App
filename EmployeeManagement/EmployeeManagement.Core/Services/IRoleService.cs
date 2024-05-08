using EmployeeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Services
{
    public interface IRoleService
    {

        public Task<List<Role>> GetAllAsync();
        public Task<Role> GetByIdAsync(int RoleId);
        public Task AddRoleAsync(Role role);
        public Task UpdateRoleAsync(int RoleId, Role role);
        public Task DeleteRoleASync(int RoleId);
    }
}
