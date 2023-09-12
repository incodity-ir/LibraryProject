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
    public class BookMapping:IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasMany(p => p.Writers).WithMany(p => p.Books);
            builder.HasMany(p => p.BookImages).WithOne(p => p.Book).HasForeignKey(p => p.BookID)
                .OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.FormnBorrows).WithOne(p => p.Book).HasForeignKey(p => p.BookID)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Property(p => p.BookName).IsRequired();

        }
    }
}
