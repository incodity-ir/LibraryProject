using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryProject.Data.Mapping
{
    public class CommunicationTypeMapping:IEntityTypeConfiguration<CommunicationType>
    {
        public void Configure(EntityTypeBuilder<CommunicationType> builder)
        {
            builder.HasMany(p => p.Communications).WithOne(p => p.CommunicationType)
                .HasForeignKey(p => p.CommunicationTypeID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
