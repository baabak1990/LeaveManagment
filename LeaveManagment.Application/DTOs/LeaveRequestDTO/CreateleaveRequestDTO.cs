using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagment.Application.DTOs.LeaveRequestDTO
{
    public class CreateleaveRequestDTO
    {
        public DateTime EndDate { get; set; }
        public DateTime DateRequest { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool? IsCanceled { get; set; }
    }
}
