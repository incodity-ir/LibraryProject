using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Entities
{
    public  class Writer:BaseEntity
    {
        public virtual string Biography { get; set; }
        //Navigation Property
        public virtual int PersonID { get; set; }
        public virtual Person Person { get; set; }
    }
}
