using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.Domain.DTOs.Intern
{
    public class InternAddDTO
    {
        public string InternName { get; set; }
        public string InternSurname { get; set; }
        public int InternCompanyID { get; set; }
        public string InternSchool { get; set; }
        public string InternSchoolDepartment { get; set; }
        public int InternManagerID { get; set; }
        public int InternDepartmentID { get; set; }
        public int InternDutyStationID { get; set; }
        public int InternInternshipTypeID { get; set; }
        public string InternPhoneNumber { get; set; }
        public string InternResponsibleTeacher { get; set; }
        public string InternTeacherPhone { get; set; }
        public string InternContactPerson { get; set; }
        public string InternContactPhone { get; set; }

    }
}
