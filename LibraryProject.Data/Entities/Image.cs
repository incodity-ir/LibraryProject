using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Entities
{
    public  class Image:BaseEntity
    {
        public Image()
        {
            BookImages = new List<BookImage>();
        }
        public virtual string ImageAddress { get; set; }
        public virtual byte[] ImageValue { get; set; }
        //Navigation Property
        public virtual ICollection<BookImage> BookImages { get; set; }
    }
}
