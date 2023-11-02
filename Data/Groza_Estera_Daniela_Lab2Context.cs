using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Groza_Estera_Daniela_Lab2.Models;

namespace Groza_Estera_Daniela_Lab2.Data
{
    public class Groza_Estera_Daniela_Lab2Context : DbContext
    {
        public Groza_Estera_Daniela_Lab2Context (DbContextOptions<Groza_Estera_Daniela_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Groza_Estera_Daniela_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Groza_Estera_Daniela_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
