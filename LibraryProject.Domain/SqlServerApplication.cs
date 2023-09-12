using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Data
{
    public class SqlServerApplication:DbContext,IApplicationService
    {
        public SqlServerApplication(DbContextOptions options):base(options)
        {
            
        }
        
    }
}
