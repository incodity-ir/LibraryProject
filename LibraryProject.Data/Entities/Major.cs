using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
    public  class Major:BaseEntity
    {
        public Major()
        {
            Members = new List<Member>();
        }
        public virtual string MajorName { get; set; }
        //Navigation property
        public virtual ICollection<Member> Members { get; set; }
    }
}
