using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            Interns = new HashSet<Intern>();
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public int? EmployeeDepartmentId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Intern> Interns { get; set; }
    }
}
