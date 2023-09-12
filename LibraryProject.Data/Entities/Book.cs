using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
    public class Book:BaseEntity
    {
        public Book()
        {
            Writers = new List<Writer>();
            FormnBorrows = new List<FormBorrow>();
        }
        public virtual string BookName { get; set; }
        public virtual string ISBN { get; set; }
        public virtual string Absrtac { get; set; }
        //Navigation Property
        public virtual int SubjectID { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<FormBorrow> FormnBorrows { get; set; }
        public virtual ICollection<Writer> Writers { get; set; }
        public virtual ICollection<BookImage> BookImages { get; set; }
    }
}
