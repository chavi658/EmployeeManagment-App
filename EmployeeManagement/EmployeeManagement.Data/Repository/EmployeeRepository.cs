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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DataContext _dataContext;
        public EmployeeRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        } 

        public async Task AddEmployeeAsync (Employee employee)
        {
            employee.IsActivate= true;
            _dataContext.Employees.Add(employee);
            await _dataContext.SaveChangesAsync();
        } 

        public async Task DeleteEmployeeAsync(int Id)
        {
            var  employeeToRemove = await GetEmployeeByIdAsync(Id);
            if (employeeToRemove != null)
            {
                employeeToRemove.IsActivate= false;
               await _dataContext.SaveChangesAsync(); // נדרש כדי לשמור את השינויים במסד הנתונים
            }
        }

        public async Task<Employee> GetEmployeeByIdAsync(int Id)
        {
            return  await  _dataContext.Employees.Include(x=>x.RoleList).FirstAsync(x=>x.Id==Id/*FindAsync(EmployeeId)*/);
            
        }

        public  async Task<List<Employee>> GetEmployeesAsync()
        {
            return  await   _dataContext.Employees.Include(x => x.RoleList).ToListAsync();
        }

        public async Task UpdateEmployeeAsync(int EmployeeId, Employee employee)
        {
            var UpdateEmployee = await GetEmployeeByIdAsync(EmployeeId);
            UpdateEmployee.Gender = employee.Gender;
            UpdateEmployee.DateOfBirth = employee.DateOfBirth;
            UpdateEmployee.FirstName = employee.FirstName;
            UpdateEmployee.LastName = employee.LastName;
            UpdateEmployee.DateOfStartingWork = employee.DateOfStartingWork;
            UpdateEmployee.IsActivate= employee.IsActivate;
            UpdateEmployee.EmployeeId = employee.EmployeeId;
            UpdateEmployee.RoleList = employee.RoleList;
            await _dataContext.SaveChangesAsync();
        }
    }
}
