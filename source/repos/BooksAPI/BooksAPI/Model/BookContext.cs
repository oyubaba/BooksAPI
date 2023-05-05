﻿using Microsoft.EntityFrameworkCore;

namespace BooksAPI.Model
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) {
             Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }

    }
}
