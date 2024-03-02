using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.Domain.DTOs.InternLeaveDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Abstract
{
    public interface IInternLeaveDetailService
    {
        Task<GeneralReturnType<InternLeaveDetailAddDTO>> InternLeaveDetailAddAsync(InternLeaveDetailAddDTO internLeaveDetailAddDTO);
    }
}
