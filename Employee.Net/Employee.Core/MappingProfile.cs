using AutoMapper;
using Employee.Core.DTOs;
using Employee.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core
{
    public class MappingProfilel :Profile
    {
        public MappingProfilel()
        {
            CreateMap<EmployeeD, EmployeeDTO>().ReverseMap();
            CreateMap<RoleD, RoleDTO>().ReverseMap();
            CreateMap<RoleForEmployeeD, RoleForEmployeeDTO>().ReverseMap();
        }
    }
}
