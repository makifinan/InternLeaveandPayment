using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class InternDay
    {
        public int InternDaysId { get; set; }
        public int? InternId { get; set; }
        public int? DayId { get; set; }

        public virtual Day Day { get; set; }
        public virtual Intern Intern { get; set; }
    }
}
