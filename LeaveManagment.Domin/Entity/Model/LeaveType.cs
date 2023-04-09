using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveManagment.Domin.Entity.Model.Common;

namespace LeaveManagment.Domin.Entity.Model
{
    public class LeaveType : BaseDomine
    {

        public string Name { get; set; }
        public int DefaultDays { get; set; }

    }
}
