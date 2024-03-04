using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class InternLeave
    {
        public InternLeave()
        {
            InternLeaveDetails = new HashSet<InternLeaveDetail>();
        }

        public int InternLeaveId { get; set; }
        public int? InternId { get; set; }
        public int? PermissionTypeId { get; set; }
        public int? StatuId { get; set; }
        public DateTime? LeaveStartDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }
        public string LeaveDescription { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
        public int ResponsibleID { get; set; }

        public virtual Intern Intern { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual Statu Statu { get; set; }
        public virtual ICollection<InternLeaveDetail> InternLeaveDetails { get; set; }
    }
}
