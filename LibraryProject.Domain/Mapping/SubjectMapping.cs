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
    public class SubjectMapping:IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasMany(p => p.Books).WithOne(p => p.Subject).HasForeignKey(p => p.SubjectID)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasIndex(p => p.SubjectName).IsUnique();
            builder.Property(p => p.SubjectName).IsRequired();s
        }
    }
}
