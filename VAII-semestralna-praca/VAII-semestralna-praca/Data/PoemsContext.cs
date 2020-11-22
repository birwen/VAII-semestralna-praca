using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VAII_semestralna_praca.Models;

namespace VAII_semestralna_praca.Data
{
    public class PoemsContext : DbContext
    {
        public PoemsContext (DbContextOptions<PoemsContext> options)
            : base(options)
        {
        }

        public DbSet<VAII_semestralna_praca.Models.Poem> Poem { get; set; }
    }
}
