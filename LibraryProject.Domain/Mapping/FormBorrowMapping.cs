﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryProject.Data.Mapping
{
    public class FormBorrowMapping:IEntityTypeConfiguration<FormBorrow>
    {
        public void Configure(EntityTypeBuilder<FormBorrow> builder)
        {
            
        }
    }
}
