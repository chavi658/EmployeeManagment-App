using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Core.Entities
{
    public class EmployeeRole
    {
        public int EmployeeRoleId { get; set; }
        public int RoleId { get; set; }
        public int EmployeeId { get; set; }

      //  public string RoleName { get; set; }
        public DateTime DateOfRoleEntry { get; set; }
        public bool IsManagerial { get; set; }
        //מה הסיפור שהוא לא מפתח זר

    }
}
