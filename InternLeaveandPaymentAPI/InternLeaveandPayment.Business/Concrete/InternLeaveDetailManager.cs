using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Business.Mapper;
using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.Domain.DTOs.InternLeaveDetail;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Concrete
{
    public class InternLeaveDetailManager : IInternLeaveDetailService
    {
        private readonly IInternLeaveDetailDAL _internLeaveDetailDAL;
        MyMapper mapper = new MyMapper(); 
        public InternLeaveDetailManager(IInternLeaveDetailDAL internLeaveDetailDAL)
        {
            _internLeaveDetailDAL = internLeaveDetailDAL;
        }

        public async Task<GeneralReturnType<InternLeaveDetailAddDTO>> InternLeaveDetailAddAsync(InternLeaveDetailAddDTO internLeaveDetailAddDTO)
        {
            GeneralReturnType<InternLeaveDetailAddDTO> returns = new GeneralReturnType<InternLeaveDetailAddDTO>();

            var result =await  _internLeaveDetailDAL.AddInternLeaveDetailAsync(mapper.Map<InternLeaveDetail,InternLeaveDetailAddDTO>(internLeaveDetailAddDTO));

            returns.Datas = mapper.Map<InternLeaveDetailAddDTO, InternLeaveDetail>(result.Datas);
            returns.Message = result.Message;
            returns.StatusCode = result.StatusCode;
            return returns;
        }
    }
}
