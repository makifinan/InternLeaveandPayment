using System;
using System.Collections.Generic;

#nullable disable

namespace InternLeaveandPayment.Domain.Entities
{
    public partial class DutyStation
    {
        public DutyStation()
        {
            Interns = new HashSet<Intern>();
        }

        public int DutyStationId { get; set; }
        public string DutyStationName { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<Intern> Interns { get; set; }
    }
}
