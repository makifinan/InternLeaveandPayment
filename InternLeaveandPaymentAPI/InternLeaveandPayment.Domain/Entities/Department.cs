using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class Department
    {
        public Department()
        {
            Interns = new HashSet<Intern>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int? DepartmentManagerId { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Intern> Interns { get; set; }
    }
}
