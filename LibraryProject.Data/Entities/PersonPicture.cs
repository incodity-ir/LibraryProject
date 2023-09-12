using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.Entities
{
    public class PersonPicture:BaseEntity
    {
        public virtual string ImageAddress { get; set; }
        public virtual byte[] ImageValue { get; set; }
        //Navigation Property
        public virtual int PersonID { get; set; }
        public virtual Person Person { get; set; }
    }
}
