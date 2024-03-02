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
    public class InternLeaveDAL : IInternLeaveDAL
    {
        private readonly InterneeLeaveandPaymentDBContext _context;

        public InternLeaveDAL(InterneeLeaveandPaymentDBContext context)
        {
            _context = context;
        }

        public async Task<int> AddInternLeaveAsync(InternLeave internLeave)
        {
            int internLeaveID=0;
            try
            {
                await _context.InternLeaves.AddAsync(internLeave);
                var result = await _context.SaveChangesAsync();
                if (result == 0)
                {
                    internLeaveID=0;
                }
                else
                {
                    internLeaveID = internLeave.InternLeaveId;
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
            return internLeaveID;
        }
    }
}
