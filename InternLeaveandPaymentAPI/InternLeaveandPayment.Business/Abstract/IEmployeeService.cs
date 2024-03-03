using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Abstract
{
    public interface IEmployeeService
    {
        Task<GeneralReturnType<Employee>> GetByEmailPassword(string email,string password);
    }
}
