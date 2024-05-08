using AutoMapper;
using EmployeeManagement.Core.DTOs;
using EmployeeManagement.Core.Entities;
using EmployeeManagement.Core.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
        }
        
    }
}
