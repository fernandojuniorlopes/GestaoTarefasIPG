using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestaoTarefasIPG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestaoTarefasIPG.Data
{
    public class GTDataContext : IdentityDbContext<IdentityUser>
    {
        public GTDataContext(DbContextOptions<GTDataContext> options)
            : base(options)
        {
        }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
