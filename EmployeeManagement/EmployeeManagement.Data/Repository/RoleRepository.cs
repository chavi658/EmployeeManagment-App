using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Data.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DataContext _dataContext;
        public RoleRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    
        public async Task AddRoleAsync(Role role)
        {
            _dataContext.Roles.Add(role);
         await   _dataContext.SaveChangesAsync();
        }

        public async Task DeleteRoleAsync(int RoleId)
        {
           var RoleForDelete= await GetRoleByIdAsync(RoleId);
            if (RoleForDelete != null)
            {
                _dataContext.Roles.Remove(RoleForDelete);
            }
          await  _dataContext.SaveChangesAsync(); 
        }

        public async Task<Role> GetRoleByIdAsync(int RoleId)
        {
            return await _dataContext.Roles.FindAsync(RoleId);

        }

        public async Task<List<Role>> GetRolesAsync()
        {
          return  await _dataContext.Roles.ToListAsync();
        }

        public  async Task UpdateRoleAsync(int RoleId, Role role)
        {
            var UpdateRole= await GetRoleByIdAsync(RoleId);
            UpdateRole.RoleName=role.RoleName;
            
          await  _dataContext.SaveChangesAsync();
        }
    }
}
