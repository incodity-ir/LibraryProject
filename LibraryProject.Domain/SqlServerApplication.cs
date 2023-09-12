using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Data
{
    public class SqlServerApplication:DbContext,IApplicationService
    {
        public SqlServerApplication(DbContextOptions options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookImage> BookImages { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<CommunicationType> CommunicationTypes { get; set; }
        public DbSet<FormBorrow> FormBorrows { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonPicture> PersonPictures { get; set; }
        public DbSet<Proof> Proofs { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
