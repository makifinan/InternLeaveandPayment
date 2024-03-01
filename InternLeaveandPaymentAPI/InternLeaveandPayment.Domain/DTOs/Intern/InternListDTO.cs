using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Domain.DTOs.Intern
{
    public class InternListDTO
    {
        public int InternId { get; set; }
        public string InternName { get; set; }
        public string InternSurname { get; set; }

        public int? InternCompanyId { get; set; }
        public string CompanyName { get; set; }

        public string InternSchool { get; set; }
        public string InternSchoolDepartment { get; set; }

        public int? InternManagerId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }


        public int? InternDepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public int? InternDutyStationId { get; set; }
        public string DutyStationName { get; set; }


        public int? InternIntershipTypeId { get; set; }
        public string InternshipTypeName { get; set; }


        public string InternPhoneNumber { get; set; }
        public string InternResponsibleTeacher { get; set; }
        public string InternTeacherPhone { get; set; }
        public string InternContactPerson { get; set; }
        public string InternContactPersonPhone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }
    }
}
