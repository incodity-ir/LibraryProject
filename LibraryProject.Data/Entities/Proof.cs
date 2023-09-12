using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
    public class Proof:BaseEntity
    {
        public Proof()
        {
            Members = new List<Member>();
        }
        public virtual string ProofName { get; set; }
        //Navigation Property
        public virtual ICollection<Member> Members { get; set; }
    } 
}
