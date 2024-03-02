using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Business.Mapper;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.Domain.DTOs.InternLeave;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Concrete
{
    public class InternLeaveManager : IInternLeaveService
    {
        private readonly IInternLeaveDAL _internLeaveDAL;
        MyMapper mapper = new MyMapper();
        public InternLeaveManager(IInternLeaveDAL internLeaveDAL)
        {
            _internLeaveDAL = internLeaveDAL;
        }

        public async Task<int> AddInternLeaveAsync(InternLeaveAddDTO internLeaveAddDTO)
        {
            var result=0;
            try
            {
                result = await _internLeaveDAL.AddInternLeaveAsync(mapper.Map<InternLeave,InternLeaveAddDTO>(internLeaveAddDTO));
            }
            catch (Exception ex)
            {

                throw;
            }
            
            if (result==0)
            {
                return 0;
            }
            return result;
        }
    }
}
