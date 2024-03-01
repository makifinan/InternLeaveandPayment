using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.Domain.DTOs.Intern;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Abstract
{
    public interface IInternService
    {
        Task<GeneralReturnType<List<InternListDTO>>> GetAllIntern();
        Task<GeneralReturnType<InternAddDTO>> AddIntern(InternAddDTO internAddDTO);
    }
}
