using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace EntityFramwork5API
{
    public partial class vbadbEntities : DbContext
    {
        public vbadbEntities(String connectionString)
            : base(connectionString)
        {

        }
    }
}
