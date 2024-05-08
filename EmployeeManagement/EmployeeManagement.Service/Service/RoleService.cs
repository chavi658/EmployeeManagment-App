using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Repositories;
using EmployeeManagement.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Service.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<List<Role>> GetAllAsync()
        {
            return await _roleRepository.GetRolesAsync();
        }
        public async Task<Role> GetByIdAsync(int RoleId)
        {
            return await _roleRepository.GetRoleByIdAsync(RoleId);
        }
        public async Task AddRoleAsync(Role role){
          await  _roleRepository.AddRoleAsync(role);
        }
        public async Task UpdateRoleAsync(int RoleId, Role role)
        {
         await   _roleRepository.UpdateRoleAsync(RoleId, role);
        }
        public async Task DeleteRoleASync(int RoleId)
        {
            await _roleRepository.DeleteRoleAsync(RoleId);
        }
    }
}
