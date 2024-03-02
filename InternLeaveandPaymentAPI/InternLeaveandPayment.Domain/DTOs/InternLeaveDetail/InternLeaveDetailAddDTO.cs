using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Domain.DTOs.InternLeaveDetail
{
    public class InternLeaveDetailAddDTO
    {
        public int? InternLeaveId { get; set; }
        public int? StatuId { get; set; }
        public int? ApprovalPerson { get; set; }
    }
}
