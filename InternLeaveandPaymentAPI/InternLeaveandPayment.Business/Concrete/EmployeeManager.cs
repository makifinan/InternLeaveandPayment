using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Business.Mapper;
using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.Domain.DTOs.Employee;
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
        MyMapper mapper = new MyMapper();
        public EmployeeManager(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public async Task<GeneralReturnType<EmployeeDetailDTO>> GetByEmailPassword(string email, string password)
        {
            return await _employeeDAL.GetByEmailPassword(email,password);
        }

        public async Task<GeneralReturnType<EmployeeDTO>> GetByIDEmployee(int id)
        {
            GeneralReturnType<EmployeeDTO> returns = new GeneralReturnType<EmployeeDTO>();

            var result = await _employeeDAL.GetByIDEmployee(id);
            returns.Datas = mapper.Map<EmployeeDTO,Employee>(result.Datas);
            returns.Message = result.Message;
            returns.StatusCode = result.StatusCode;
            return returns;
        }
    }
}
