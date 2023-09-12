using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Entities
{
    public  class CommunicationType:BaseEntity
    {
        public virtual string CommunicationTypeName { get; set; }
        
        //Navigation Property
        public virtual Communication Communication { get; set; }
    }
}
