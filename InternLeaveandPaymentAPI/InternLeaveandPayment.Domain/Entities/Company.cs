using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class Company
    {
        public Company()
        {
            Interns = new HashSet<Intern>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Intern> Interns { get; set; }
    }
}
