using EmployeeManagement.Core.DTOs;
using EmployeeManagement.Core.Entities;

namespace EmployeeManagement.Api.NewFolder2
{
    public class EmployeePostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public DateTime DateOfStartingWork { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public List<EmployeeRole> RoleList { get; set; }
    }
}
