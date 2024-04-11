using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.DTOs
{
    public class RoleForEmployeeDTO
    {
        public int Id { get; set; }
        public int RoleDId { get; set; }
        public string RoleName { get; set; }
        public bool IsManagerial { get; set; }

        public DateTime EntryDate { get; set; }
    }
}
