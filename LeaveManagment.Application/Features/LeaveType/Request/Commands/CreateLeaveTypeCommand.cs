using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagment.Application.DTOs.LeaveType;
using LeaveManagment.Application.DTOs.LeaveTypeDTO;
using MediatR;

namespace LeaveManagment.Application.Features.LeaveType.Request.Commands
{
    public class CreateLeaveTypeCommand:IRequest<int>
    {
        public LeaveTypeDTO LeaveTypeDto { get; set; }
    }
}
