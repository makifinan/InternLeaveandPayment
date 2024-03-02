using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class EmployeeScreen
    {
        public int EmployeeScreenId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ScreenId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Screeen Screen { get; set; }
    }
}
