using LeaveManagment.Domin.Entity.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagment.Domin.Entity.Model
{
    public class LeaveRequest : BaseDomine
    {
      
       
        public DateTime EndDate { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequest { get; set; }
        public string RequestComments { get; set; }
        public DateTime DateActioned { get; set; }

         
        public bool? Approved { get; set; }
        public bool IsCanceled { get; set; }

    }
}
