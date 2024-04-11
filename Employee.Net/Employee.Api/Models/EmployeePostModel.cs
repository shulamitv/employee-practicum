using Employee.Core.Models;

namespace Employee.Api.Models
{
    public class EmployeePostModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public bool Status { get; set; }
        public DateTime BirthDate { get; set; }
        public gender Gender { get; set; }
        public List<RoleForEmployeePostModel> RolesForEmployees { get; set; }
    }
}
