using CleanNotepad.InterfaceAdapterForDB.DBObject;
using Microsoft.EntityFrameworkCore;

namespace CleanNotepad.InterfaceAdapterForDB
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
