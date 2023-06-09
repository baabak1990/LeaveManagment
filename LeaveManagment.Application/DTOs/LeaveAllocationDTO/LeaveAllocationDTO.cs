﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagment.Application.DTOs.LeaveType;
using LeaveManagment.Domin.Entity.Model.Common;

namespace LeaveManagment.Application.DTOs.LeaveAllocationDTO
{
    public class LeaveAllocationDTO:BaseDTO.BaseDTO
    {
        public int NumberOfDays { get; set; }
        public LeaveType.LeaveTypeDTO LeaveTypeDto { get; set; }
        public int LeaveTypeDtoId { get; set; }
        public int Period { get; set; }
    }
}
