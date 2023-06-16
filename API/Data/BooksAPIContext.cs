using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Model;

namespace API.Data
{
    public class BooksAPIContext : DbContext
    {
        public BooksAPIContext (DbContextOptions<BooksAPIContext> options)
            : base(options)
        {
        }

        public DbSet<API.Model.Author> Author { get; set; } = default!;

        public DbSet<API.Model.Book>? Book { get; set; }

        public DbSet<API.Model.Category>? Category { get; set; }

        public DbSet<API.Model.Loan>? Loan { get; set; }

        public DbSet<API.Model.Rating>? Rating { get; set; }

        public DbSet<API.Model.Reader>? Reader { get; set; }
    }
}
