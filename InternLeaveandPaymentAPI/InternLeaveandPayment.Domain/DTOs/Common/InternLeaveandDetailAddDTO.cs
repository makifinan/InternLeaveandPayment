using InternLeaveandPayment.Domain.DTOs.InternLeave;
using InternLeaveandPayment.Domain.DTOs.InternLeaveDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Domain.DTOs.Common
{
    public class InternLeaveandDetailAddDTO
    {
        public InternLeaveAddDTO InternLeaveAddDTO { get; set; }
        public InternLeaveDetailAddDTO InternLeaveDetailAddDTO { get; set; }
    }
}
