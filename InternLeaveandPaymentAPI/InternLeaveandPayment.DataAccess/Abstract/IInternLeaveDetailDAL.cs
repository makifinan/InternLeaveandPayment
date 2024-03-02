using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.DataAccess.Abstract
{
    public interface IInternLeaveDetailDAL
    {
        Task<GeneralReturnType<InternLeaveDetail>> AddInternLeaveDetailAsync(InternLeaveDetail internLeaveDetail); 

    }
}
