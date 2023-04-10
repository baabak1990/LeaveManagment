using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagment.Application.DTOs.LeaveRequestDTO;
using MediatR;

namespace LeaveManagment.Application.Features.LeaveRequest.Request.Commands
{
    public class EditleaveRequestCommand:IRequest<Unit>
    {
        public int Id { get; set; }
        public EditleaveRequestDTO EditleaveRequestDto { get; set; }
        public EditLeaveRequestApproval EditLeaveRequestApproval { get; set; }

    }
}
