﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Entities
{
    public class Communication:BaseEntity
    {
        public virtual string Value { get; set; }

        //Navigation Property
        public virtual int PersonID { get; set; }
        public virtual Person Person { get; set; }
        public virtual int CommunicationTypeID { get; set; }
        public virtual CommunicationType CommunicationType { get; set; }
    }
}
