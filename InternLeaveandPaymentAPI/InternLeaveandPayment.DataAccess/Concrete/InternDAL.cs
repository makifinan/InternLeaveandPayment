using InternLeaveandPayment.Core.Result;
using InternLeaveandPayment.DataAccess.Abstract;
using InternLeaveandPayment.DataAccess.Connection;

using InternLeaveandPayment.Domain.DTOs.Intern;
using InternLeaveandPayment.Domain.Entities;
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

        public async Task<GeneralReturnType<Intern>> AddInternAsync(Intern intern)
        {
            GeneralReturnType<Intern> result = new GeneralReturnType<Intern>();
            try
            {
                await _context.Interns.AddAsync(intern);
                var response = await _context.SaveChangesAsync();
                if (response==1)
                {
                    result.Datas = intern;
                    result.StatusCode = 200;
                    result.Message = "Kayıt Başarılı";
                }
            }
            catch (Exception ex)
            {
                result.Datas = null;
                result.StatusCode = 400;
                result.Message = "Ekleme işlemi yapılırken hata ile karşılaşıldı. Hata: "+ex;
                
            }
            return result;
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

        public async Task<GeneralReturnType<Intern>> GetByEmailPassword(string email, string password)
        {
            GeneralReturnType<Intern> returns = new GeneralReturnType<Intern>();

            var user = await _context.Interns.FirstOrDefaultAsync(intern=>intern.Email==email && intern.Password==password);
            if (user==null)
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
