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
    public class PersonMapping:IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasMany(p => p.Communications).WithOne(p => p.Person).HasForeignKey(p => p.PersonID)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasIndex(p => p.INID).IsUnique();
            builder.Property(p => p.FirstName).IsRequired();
            builder.Property(p => p.LastName).IsRequired();
            builder.Ignore(p => p.FullName);
            builder.HasOne(p => p.PersonPicture).WithOne(p => p.Person).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
