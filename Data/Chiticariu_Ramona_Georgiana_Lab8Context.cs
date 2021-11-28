using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chiticariu_Ramona_Georgiana_Lab8.Models;

namespace Chiticariu_Ramona_Georgiana_Lab8.Data
{
    public class Chiticariu_Ramona_Georgiana_Lab8Context : DbContext
    {
        public Chiticariu_Ramona_Georgiana_Lab8Context (DbContextOptions<Chiticariu_Ramona_Georgiana_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Chiticariu_Ramona_Georgiana_Lab8.Models.Book> Book { get; set; }

        public DbSet<Chiticariu_Ramona_Georgiana_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Chiticariu_Ramona_Georgiana_Lab8.Models.Category> Category { get; set; }
    }
}
