using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Models
{
    public class RoleForEmployeeD
    {
        public int Id { get; set; }
        public int EmployeeDId { get; set; }
        public int RoleDId { get; set; }
        public string RoleName { get; set; }
        public bool Status { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsManagerial { get; set; }

        //public EmployeeD EmployeeO { get; set; }
        //public RoleD RoleO { get; set; }
    }
}
