namespace Employee.Api.Models
{
    public class RoleForEmployeePostModel
    {
        public int RoleDId { get; set; }
        public string RoleName { get; set; }
        public DateTime EntryDate { get; set; }
        public bool IsManagerial { get; set; }

    }
}
