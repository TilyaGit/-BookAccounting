namespace Book.Win
{
    using Book.Core;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BookContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Reader> Readers { get; set; }
        public BookContext()
            : base("name=Book")
        {
        }
    }
}