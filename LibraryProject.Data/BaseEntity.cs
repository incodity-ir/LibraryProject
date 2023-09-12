using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data
{
    public class BaseEntity:Entity,IDateEntity
    {
        public virtual int ID { get; set; }
        public virtual DateTime CreateON { get; set; }
        public virtual DateTime UpdateON { get; set; }
    }
}
