using CleanNotepad.InterfaceAdapter.DBObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CleanNotepad.InterfaceAdapter
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        internal DbSet<MemoDBObject> MemoDBObjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemoDBObject>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<MemoDBObject>()
                .Property(x => x.MemoText)
                .IsRequired();
        }
    }
}
