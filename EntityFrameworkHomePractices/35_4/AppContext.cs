using System;
using System.Collections.Generic;
using System.Text;

namespace _35_4
{
    public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }

        // Объекты таблицы Books
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-K2OKUF2;Database=EFHomePractices;Trusted_Connection=True;");
        }
    }
}
