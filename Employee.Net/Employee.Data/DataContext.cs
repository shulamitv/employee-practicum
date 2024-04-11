using Employee.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data
{
    public class DataContext : DbContext
    {
        public DbSet<EmployeeD> Employees { get; set; }  
        public DbSet<RoleD> Roles { get; set; }
        public DbSet<RoleForEmployeeD> RolesForEmployees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=sample_db");
        }
    }
}
