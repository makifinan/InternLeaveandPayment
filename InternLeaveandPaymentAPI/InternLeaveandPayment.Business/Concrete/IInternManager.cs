using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Business.Mapper;
using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.Domain.DTOs.Intern;
using InternLeaveandPayment.Domain.Entities;
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
        MyMapper mapper = new MyMapper();
        public InternManager(IInternDAL internDAL)
        {
            _internDAL = internDAL;
        }

        public async Task<GeneralReturnType<InternAddDTO>> AddIntern(InternAddDTO internAddDTO)
        {
            GeneralReturnType<InternAddDTO> results = new GeneralReturnType<InternAddDTO>();
            
            var result =  await _internDAL.AddInternAsync(mapper.Map<Intern,InternAddDTO>(internAddDTO));
            results.Datas = mapper.Map<InternAddDTO, Intern>(result.Datas);
            results.Message = result.Message;
            results.StatusCode = result.StatusCode;

            return results;
        }

        public async Task<GeneralReturnType<List<InternListDTO>>> GetAllIntern()
        {
            var result = await  _internDAL.GetAllInternAsync();
            return result;
        }

        public async Task<GeneralReturnType<Intern>> GetByEmailPassword(string email, string password)
        {
            return await _internDAL.GetByEmailPassword(email,password);
        }
    }
}
