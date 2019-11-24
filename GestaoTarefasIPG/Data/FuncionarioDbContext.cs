using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GestaoTarefasIPG.Models
{
    public class FuncionarioDbContext : DbContext
    {
        public FuncionarioDbContext (DbContextOptions<FuncionarioDbContext> options)
            : base(options)
        {
        }

        public DbSet<GestaoTarefasIPG.Models.Funcionario> Funcionario { get; set; }
    }
}
