using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagment.Application.DTOs.LeaveAllocationDTO;
using LeaveManagment.Application.DTOs.LeaveRequestDTO;
using LeaveManagment.Application.DTOs.LeaveType;
using LeaveManagment.Domin.Entity.Model;

namespace LeaveManagment.Application.Profille
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDTO>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDTO>().ReverseMap();
        }
    }
}
