using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class InternLeaveDetail
    {
        public int InternLeaveDetailId { get; set; }
        public int? InternLeaveId { get; set; }
        public int? StatuId { get; set; }
        public int? ApprovalPerson { get; set; }

        public virtual Employee ApprovalPersonNavigation { get; set; }
        public virtual InternLeave InternLeave { get; set; }
        public virtual Statu Statu { get; set; }
    }
}
