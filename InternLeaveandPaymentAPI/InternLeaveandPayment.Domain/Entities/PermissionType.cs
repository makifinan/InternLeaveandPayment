using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class PermissionType
    {
        public PermissionType()
        {
            InternLeaves = new HashSet<InternLeave>();
        }

        public int PermissionTypeId { get; set; }
        public string PermissionTypeName { get; set; }
        public string IsActive { get; set; }

        public virtual ICollection<InternLeave> InternLeaves { get; set; }
    }
}
