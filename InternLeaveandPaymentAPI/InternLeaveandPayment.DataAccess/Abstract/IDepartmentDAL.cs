using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.Domain.DTOs.Department;
using InternLeaveandPayment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.DataAccess.Abstract
{
    public interface IDepartmentDAL
    {
        GeneralReturnType<Department> GetAllDepartment(int id);
    }
}
