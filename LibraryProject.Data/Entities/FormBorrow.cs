using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Entities
{
    public class FormBorrow:BaseEntity
    {
        public virtual DateTime BorrowDate { get; set; }
        public virtual int QuantityDays { get; set; }
        //Navigation Property
        public virtual int BookID { get; set; }
        public virtual Book Book { get; set; }
        public virtual int MemberID { get; set; }
        public virtual Member Member { get; set; }
    }
}
