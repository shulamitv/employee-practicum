using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Models
{
    public enum gender
    {
        mal,
        female
    }
    public class EmployeeD
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public bool Status { get; set; }
        public DateTime BirthDate { get; set; }
        public gender Gender { get; set; }
        public List<RoleForEmployeeD> RolesForEmployees{ get; set; }

    }
}
