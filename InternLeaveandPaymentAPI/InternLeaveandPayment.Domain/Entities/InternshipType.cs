using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class InternshipType
    {
        public InternshipType()
        {
            Interns = new HashSet<Intern>();
        }

        public int InternshipTypeId { get; set; }
        public string InternshipTypeName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Intern> Interns { get; set; }
    }
}
