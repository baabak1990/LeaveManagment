using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagment.Application.DTOs.LeaveRequestDTO
{
    public class EditLeaveRequestApproval:BaseDTO.BaseDTO
    {
        public bool? Approved { get; set; }
    }
}
