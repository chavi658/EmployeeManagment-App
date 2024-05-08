using EmployeeManagement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Repositories
{
    public interface IRoleRepository
    {
        public Task<List<Role>> GetRolesAsync();
        public Task<Role> GetRoleByIdAsync(int RoleId);
        public  Task AddRoleAsync(Role role);
        public Task UpdateRoleAsync(int RoleId, Role role);
        public Task DeleteRoleAsync(int RoleId);
    }
}
