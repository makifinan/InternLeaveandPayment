using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class Intern
    {
        public Intern()
        {
            InternDays = new HashSet<InternDay>();
            InternLeaves = new HashSet<InternLeave>();
        }

        public int InternId { get; set; }
        public string InternName { get; set; }
        public string InternSurname { get; set; }
        public int? InternCompanyId { get; set; }
        public string InternSchool { get; set; }
        public string InternSchoolDepartment { get; set; }
        public int? InternManagerId { get; set; }
        public int? InternDepartmentId { get; set; }
        public int? InternDutyStationId { get; set; }
        public int? InternIntershipTypeId { get; set; }
        public string InternPhoneNumber { get; set; }
        public string InternResponsibleTeacher { get; set; }
        public string InternTeacherPhone { get; set; }
        public string InternContactPerson { get; set; }
        public string InternContactPersonPhone { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Company InternCompany { get; set; }
        public virtual Department InternDepartment { get; set; }
        public virtual DutyStation InternDutyStation { get; set; }
        public virtual InternshipType InternIntershipType { get; set; }
        public virtual Employee InternManager { get; set; }
        public virtual ICollection<InternDay> InternDays { get; set; }
        public virtual ICollection<InternLeave> InternLeaves { get; set; }
    }
}
