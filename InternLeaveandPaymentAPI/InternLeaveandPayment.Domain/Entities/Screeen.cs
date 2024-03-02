using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class Screeen
    {
        public Screeen()
        {
            EmployeeScreens = new HashSet<EmployeeScreen>();
        }

        public int ScreenId { get; set; }
        public string ScreenName { get; set; }

        public virtual ICollection<EmployeeScreen> EmployeeScreens { get; set; }
    }
}
