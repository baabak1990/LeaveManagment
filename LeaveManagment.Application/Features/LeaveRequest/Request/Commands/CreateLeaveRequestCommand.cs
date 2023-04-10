using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagment.Application.DTOs.LeaveRequestDTO;
using MediatR;

namespace LeaveManagment.Application.Features.LeaveRequest.Request.Commands
{
    public class CreateLeaveRequestCommand:IRequest<int>
    {
        public LeaveRequestDTO LeaveRequestDto { get; set; }
    }
}
