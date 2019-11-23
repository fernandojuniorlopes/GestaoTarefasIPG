using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestaoTarefasIPG.Models
{
    public class ProfessorDbContext : DbContext
    {
        public ProfessorDbContext (DbContextOptions<ProfessorDbContext> options)
            : base(options)
        {
        }

        public DbSet<GestaoTarefasIPG.Models.Professor> Professor { get; set; }
    }
}
