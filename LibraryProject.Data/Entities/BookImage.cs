using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Entities
{
    public class BookImage:BaseRelation
    {
        public virtual int BookID { get; set; }
        public virtual int ImageID { get; set; }
        //Navigation property
        public virtual Book Book { get; set; }
        public virtual Image Image { get; set; }
    }
}
