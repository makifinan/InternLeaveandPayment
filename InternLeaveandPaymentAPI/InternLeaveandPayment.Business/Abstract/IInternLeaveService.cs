using InternLeaveandPayment.Domain.DTOs.InternLeave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Abstract
{
    public interface IInternLeaveService
    {
        Task<int> AddInternLeaveAsync(InternLeaveAddDTO internLeaveAddDTO);
    }
}
