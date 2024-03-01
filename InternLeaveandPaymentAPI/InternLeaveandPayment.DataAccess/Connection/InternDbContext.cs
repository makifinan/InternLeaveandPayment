using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternLeaveandPayment.DataAccess.Connection
{
    public class InternDbContext :  DbContext
    {
        public InternDbContext(DbContextOptions<InternDbContext> options) : base(options)
        {

        }
    }
}
