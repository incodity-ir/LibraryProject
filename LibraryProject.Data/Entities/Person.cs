using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
    public class Person:BaseEntity
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FullName => FirstName + " " + LastName;
        public virtual int INID { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        //Navigation Property
        public virtual PersonPicture PersonPicture { get; set; }
        public virtual ICollection<Communication> Communications { get; set; }
    }
}
