﻿using LeaveManagment.Domin.Entity.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagment.Domin.Entity.Model
{
    public class LeaveAllocation : BaseDomine
    {
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
