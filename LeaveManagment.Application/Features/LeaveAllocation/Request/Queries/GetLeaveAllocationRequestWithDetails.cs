﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagment.Application.DTOs.LeaveAllocationDTO;
using MediatR;

namespace LeaveManagment.Application.Features.LeaveAllocation.Request.Queries
{
    public class GetLeaveAllocationRequestWithDetails:IRequest<LeaveAllocationDTO>
    {
        public int Id { get; set; }
    }
}
