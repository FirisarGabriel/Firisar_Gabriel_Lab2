using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Firisar_Gabriel_Lab2.Models;

namespace Firisar_Gabriel_Lab2.Data
{
    public class Firisar_Gabriel_Lab2Context : DbContext
    {
        public Firisar_Gabriel_Lab2Context (DbContextOptions<Firisar_Gabriel_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Firisar_Gabriel_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Firisar_Gabriel_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
