using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Entities
{
    public  class Subject:BaseEntity
    {
        public Subject()
        {
            Books = new List<Book>();
        }
        public virtual string SubjectName { get; set; }
        //Navigation Property
        public virtual ICollection<Book> Books { get; set; }
    }
}
