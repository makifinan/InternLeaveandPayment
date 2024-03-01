using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class Day
    {
        public Day()
        {
            InternDays = new HashSet<InternDay>();
        }

        public int DayId { get; set; }
        public string DayName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<InternDay> InternDays { get; set; }
    }
}
