using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.DataAccess.Connection;
using InternLeaveandPayment.Domain.DTOs.Department;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.DataAccess.Concrete
{
    public class DepartmentDAL : IDepartmentDAL
    {
        private readonly InterneeLeaveandPaymentDBContext _context;
        
        public DepartmentDAL(InterneeLeaveandPaymentDBContext context)
        {
            _context = context;
        }

        public GeneralReturnType<Department> GetAllDepartment(int id)
        {
            GeneralReturnType<Department> returns = new GeneralReturnType<Department>();
            var result = _context.Departments.FirstOrDefault(d=>d.DepartmentId==id);
            if (result==null)
            {
                returns.Datas = null;
                returns.Message = "data yok";
                returns.StatusCode = 400;
            }
            else
            {
                returns.Datas = result;
                returns.Message = "Veri Bulundu.";
                returns.StatusCode = 200;
            }

            return returns;
        }
    }
}
