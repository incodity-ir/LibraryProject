using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data
{
    public interface IDateEntity
    {
        public DateTime CreateON { get; set; }
        public DateTime UpdateON { get; set; }
    }
}
