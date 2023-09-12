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
    public class PersonPictureMapping:IEntityTypeConfiguration<PersonPicture>
    {
        public void Configure(EntityTypeBuilder<PersonPicture> builder)
        {
            builder.HasKey(p => p.PersonID);

        }
    }
}
