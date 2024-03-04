using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.Domain.DTOs.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Business.Abstract
{
    public interface IDepartmentService
    {
        GeneralReturnType<DepartmentListDTO> GetAllDepartment(int id);
    }
}
