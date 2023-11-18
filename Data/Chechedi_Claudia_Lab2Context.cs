using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Chechedi_Claudia_Lab2.Models;

namespace Chechedi_Claudia_Lab2.Data
{
    public class Chechedi_Claudia_Lab2Context : DbContext
    {
        public Chechedi_Claudia_Lab2Context (DbContextOptions<Chechedi_Claudia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Chechedi_Claudia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Chechedi_Claudia_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Chechedi_Claudia_Lab2.Models.Author>? Author { get; set; }
    }
}
