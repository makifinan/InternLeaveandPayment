using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.DataAccess.Entities;
using InternLeaveandPayment.Domain.DTOs.Intern;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.DataAccess.Concrete
{
    public class InternDAL : IInternDAL
    {
        private readonly InterneeLeaveandPaymentDBContext _context;

        public InternDAL(InterneeLeaveandPaymentDBContext context)
        {
            _context = context;
        }

        public async Task<GeneralReturnType<List<InternListDTO>>> GetAllInternAsync()
        {
            GeneralReturnType<List<InternListDTO>> result = new GeneralReturnType<List<InternListDTO>>();

            try
            {
                var data = await (from intern in _context.Interns
                           join company in _context.Companies on intern.InternCompanyId equals company.CompanyId
                           join employee in _context.Employees on intern.InternManagerId equals employee.EmployeeId
                           join department in _context.Departments on intern.InternDepartmentId equals department.DepartmentId
                           join dutystation in _context.DutyStations on intern.InternDutyStationId equals dutystation.DutyStationId
                           join internshiptype in _context.InternshipTypes on intern.InternIntershipTypeId equals internshiptype.InternshipTypeId
                           select new InternListDTO()
                           {
                               InternId = intern.InternId,
                               InternName = intern.InternName,
                               InternSurname = intern.InternSurname,
                               InternCompanyId = intern.InternCompanyId,
                               CompanyName = company.CompanyName,
                               InternSchool = intern.InternSchool,
                               InternSchoolDepartment = intern.InternSchoolDepartment,
                               InternManagerId = intern.InternManagerId,
                               EmployeeName = employee.EmployeeName,
                               EmployeeSurname = employee.EmployeeSurname,
                               InternDepartmentId = intern.InternDepartmentId,
                               DepartmentName = department.DepartmentName,
                               InternDutyStationId = intern.InternDutyStationId,
                               DutyStationName = dutystation.DutyStationName,
                               InternIntershipTypeId = intern.InternIntershipTypeId,
                               InternshipTypeName = internshiptype.InternshipTypeName,
                               InternPhoneNumber = intern.InternPhoneNumber,
                               InternResponsibleTeacher = intern.InternResponsibleTeacher,
                               InternTeacherPhone = intern.InternTeacherPhone,
                               InternContactPerson = intern.InternContactPerson,
                               InternContactPersonPhone = intern.InternContactPersonPhone,
                               CreatedDate = intern.CreatedDate,
                               IsActive = intern.IsActive
                           }).ToListAsync();
                result.Datas = data;
                result.Message = "Veri Çekme Başarılı";
                result.StatusCode = 200;
            }
            catch (Exception ex)
            {
                result.Datas = null;
                result.Message = "Veri Çekme Başarısız" + ex.Message;
                result.StatusCode = 400;
                
            }

            return result;

        }
    }
}
