using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagment.Application.DTOs.LeaveTypeDTO
{
    public class ditLeaveTypeDTO:BaseDTO.BaseDTO
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
