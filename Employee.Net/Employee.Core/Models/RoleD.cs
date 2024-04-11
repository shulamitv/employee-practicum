using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Models
{
    //public enum RoleName
    //{
    //    SoftwareDeveloper,
    //    HardwareEngineer,
    //    DataScientist,
    //    NetworkEngineer,
    //    QualityAssurance,
    //    UIDesigner,
    //    ProductManager,
    //}
    public class RoleD
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<RoleForEmployeeD> RolesForEmployees { get; set; }
    }
}
