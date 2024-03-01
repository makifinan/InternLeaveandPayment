using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.Domain.DTOs.Intern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Concrete
{
    public class InternManager : IInternService
    {
        private readonly IInternDAL _internDAL;

        public InternManager(IInternDAL internDAL)
        {
            _internDAL = internDAL;
        }

        public async Task<GeneralReturnType<List<InternListDTO>>> GetAllIntern()
        {
            var result = await  _internDAL.GetAllInternAsync();
            return result;
        }
    }
}
