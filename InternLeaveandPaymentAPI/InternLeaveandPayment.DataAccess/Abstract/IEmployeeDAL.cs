using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.Domain.DTOs.Employee;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.DataAccess.Abstract
{
    public interface IEmployeeDAL
    {
        Task<GeneralReturnType<EmployeeDetailDTO>> GetByEmailPassword(string email, string password);
    }
}
