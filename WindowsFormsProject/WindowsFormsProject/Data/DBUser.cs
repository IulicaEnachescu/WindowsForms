using Models;
using System.Data.Entity;


namespace WindowsFormsProject.Data
{
    public class DBUser:DbContext
    {

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<User>()
                .HasIndex(e => e.UserName).IsUnique();
            
            builder.Entity<Author>()
                .HasMany(p => p.Books);

            builder.Entity<Book>()
                .HasMany(b => b.Authors);
        }



        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
