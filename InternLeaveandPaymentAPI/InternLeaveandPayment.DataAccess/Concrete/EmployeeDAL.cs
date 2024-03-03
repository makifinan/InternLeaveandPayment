using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.DataAccess.Connection;
using InternLeaveandPayment.Domain.DTOs.Employee;
using InternLeaveandPayment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.DataAccess.Concrete
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly InterneeLeaveandPaymentDBContext _context;

        public EmployeeDAL(InterneeLeaveandPaymentDBContext context)
        {
            _context = context;
        }

        public async Task<GeneralReturnType<EmployeeDetailDTO>> GetByEmailPassword(string email, string password)
        {
            GeneralReturnType<EmployeeDetailDTO> returns = new GeneralReturnType<EmployeeDetailDTO>();
            var user = (from employee in _context.Employees
                        join department in _context.Departments on employee.EmployeeDepartmentId equals department.DepartmentId
                        where employee.Email==email && employee.Password==password
                        select new EmployeeDetailDTO()
                        {
                            EmployeeId = employee.EmployeeId,
                            EmployeeName = employee.EmployeeName,
                            EmployeeSurname = employee.EmployeeSurname,
                            Email = employee.Email,
                            EmployeeDepartmentId = employee.EmployeeDepartmentId,
                            DepartmentName = department.DepartmentName,
                            IsActive = employee.IsActive,
                        }).FirstOrDefault();
            //var user = await _context.Employees.FirstOrDefaultAsync(intern => intern.Email == email && intern.Password == password);
            if (user == null)
            {
                returns.Datas = null;
                returns.Message = "Kullanıcı bulunamadı";
                returns.StatusCode = 400;
            }
            else
            {
                returns.Datas = user;
                returns.Message = "Kullanıcı Bulundu";
                returns.StatusCode = 400;
            }
            return returns;

            
        }
    }
}
