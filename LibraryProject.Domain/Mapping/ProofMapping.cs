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
    public class ProofMapping:IEntityTypeConfiguration<Proof>
    {
        public void Configure(EntityTypeBuilder<Proof> builder)
        {
            builder.HasIndex(p => p.ProofName).IsUnique();
            builder.Property(p => p.ProofName).IsRequired();
            builder.HasMany(p => p.Members).WithOne(p => p.Proof).HasForeignKey(p => p.ProofID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
