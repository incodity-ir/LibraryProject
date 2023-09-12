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
    public class ImageMapping:IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasMany(p => p.BookImages).WithOne(p => p.Imag).HasForeignKey(p => p.ImageID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
