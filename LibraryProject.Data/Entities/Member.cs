using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Entities
{
    public class Member:BaseEntity
    {
        
        public virtual DateTime Birthday { get; set; }
        //Navigation Property
        public virtual int PersonID { get; set; }
        public virtual Person Person { get; set; }
        public virtual int MajorID { get; set; }
        public virtual Major Major { get; set; }
        public virtual int ProofID { get; set; }
        public virtual Proof Proof { get; set; }
    }
}
