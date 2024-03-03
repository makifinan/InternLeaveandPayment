using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDAL _employeeDAL;

        public EmployeeManager(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public async Task<GeneralReturnType<Employee>> GetByEmailPassword(string email, string password)
        {
            return await _employeeDAL.GetByEmailPassword(email,password);
        }
    }
}
