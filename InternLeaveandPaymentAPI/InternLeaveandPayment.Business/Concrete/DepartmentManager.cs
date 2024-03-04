using InternLeaveandPayment.Business.Abstract;
using InternLeaveandPayment.Business.Mapper;
using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.Domain.DTOs.Department;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDAL _departmentDAL;
        MyMapper mapper = new MyMapper();
        public DepartmentManager(IDepartmentDAL departmentDAL)
        {
            _departmentDAL = departmentDAL;
        }

        public GeneralReturnType<DepartmentListDTO> GetAllDepartment(int id)
        {
            GeneralReturnType<DepartmentListDTO> returns = new GeneralReturnType<DepartmentListDTO>();
            var result = _departmentDAL.GetAllDepartment(id);
            returns.Datas = mapper.Map<DepartmentListDTO,Department>(result.Datas);
            returns.Message = result.Message;
            returns.StatusCode = result.StatusCode;
            return returns;
        }
    }
}
