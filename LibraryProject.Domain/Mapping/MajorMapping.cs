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
    public class MajorMapping:IEntityTypeConfiguration<Major>
    {
        public void Configure(EntityTypeBuilder<Major> builder)
        {
            builder.HasIndex(p => p.MajorName).IsUnique();
            builder.Property(p => p.MajorName).IsRequired();
            builder.HasMany(p=>p.Members).WithOne(p=>p.Major).HasForeignKey(p=>p.MajorID).OnDelete(DeleteBehavior.NoAction)
        }
    }
}
