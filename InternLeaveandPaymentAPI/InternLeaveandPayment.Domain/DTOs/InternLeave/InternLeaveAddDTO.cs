using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Domain.DTOs.InternLeave
{
    public class InternLeaveAddDTO
    {
      
        public int? InternId { get; set; }
        public int? PermissionTypeId { get; set; }
        public int? StatuId { get; set; }
        public DateTime? LeaveStartDate { get; set; }
        public DateTime? LeaveEndDate { get; set; }
        public string LeaveDescription { get; set; }
        public int ResponsibleID { get; set; }

    }
}
