using LeaveManagment.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagment.Application.DTOs.LeaveAllocationDTO
{
    public class ListOfLeaveAllocationWithDetails : BaseDTO.BaseDTO
    {
        public int NumberOfDays { get; set; }
        public int LeaveTypeDtoId { get; set; }
    }
}
