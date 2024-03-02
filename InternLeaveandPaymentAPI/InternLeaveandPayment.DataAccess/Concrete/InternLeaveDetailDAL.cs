using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.DataAccess.Connection;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.DataAccess.Concrete
{
    public class InternLeaveDetailDAL : IInternLeaveDetailDAL
    {
        private readonly InterneeLeaveandPaymentDBContext _context;

        public InternLeaveDetailDAL(InterneeLeaveandPaymentDBContext context)
        {
            _context = context;
        }

        public async Task<GeneralReturnType<InternLeaveDetail>> AddInternLeaveDetailAsync(InternLeaveDetail internLeaveDetail)
        {
            GeneralReturnType<InternLeaveDetail> returns = new GeneralReturnType<InternLeaveDetail>();

            try
            {
                await _context.InternLeaveDetails.AddAsync(internLeaveDetail);
                var result = await _context.SaveChangesAsync();

                if (result==0)
                {
                    returns.Datas = null;
                    returns.StatusCode = 400;
                    returns.Message = "Ekleme işlemi başarısız";
                }
                else
                {
                    returns.Datas = internLeaveDetail;
                    returns.Message = "Ekleme işlemi başarılı";
                    returns.StatusCode = 200;
                }
            }
            catch (Exception ex)
            {
                returns.Datas = null;
                returns.Message = "Ekleme işlemi yaparken hata ile karşılaşıldı." + ex;
                returns.StatusCode = 400;
                
            }
            return returns;
        }
    }
}
