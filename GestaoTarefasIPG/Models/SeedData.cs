using GestaoTarefasIPG.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class SeedData
    {
        const string ADMIN_ROLE = "ADMIN";
        const string BOSS_PROF_ROLE = "BossProf";
        const string BOSS_FUNC_ROLE = "BossFunc";
        const string PROF_ROLE = "Prof";
        const string FUNC_ROLE = "Func";

        public static void Populate(ProfessorDbContext db)
        {
            if (db.Professor.Any())
            {
                return;
            }

            db.Professor.AddRange(
                new Professor { Nome = "Nil Silva", NumeroTelemovel = "961123456", Email = "nil@silva.com", Gabinete = "1", NumFuncionario = "1" },
                new Professor { Nome = "Fernando Lopes", NumeroTelemovel = "936654321", Email = "nado@lopes.pt", Gabinete = "2", NumFuncionario = "2" },
                new Professor { Nome = "Nikita", NumeroTelemovel = "232546123", Email = "niki@ta.com", Gabinete = "3", NumFuncionario = "3" },
                new Professor { Nome = "Jacinta", NumeroTelemovel = "912123456", Email = "jacinta@gmail.com", Gabinete = "4", NumFuncionario = "4" },
                new Professor { Nome = "Teste 1", NumeroTelemovel = "927895612", Email = "teste@1.com", Gabinete = "5", NumFuncionario = "5" },
                new Professor { Nome = "Teste 2", NumeroTelemovel = "921234568", Email = "teste@2.com", Gabinete = "6", NumFuncionario = "6" },
                new Professor { Nome = "Teste 3", NumeroTelemovel = "965874956", Email = "teste@3.com", Gabinete = "7", NumFuncionario = "7" },
                new Professor { Nome = "Teste 4", NumeroTelemovel = "935845612", Email = "teste@4.com", Gabinete = "8", NumFuncionario = "8" },
                new Professor { Nome = "Teste 5", NumeroTelemovel = "232548912", Email = "teste@5.com", Gabinete = "9", NumFuncionario = "9" },
                new Professor { Nome = "Teste 6", NumeroTelemovel = "232548796", Email = "teste@6.com", Gabinete = "10", NumFuncionario = "10" },
                new Professor { Nome = "Teste 7", NumeroTelemovel = "232158463", Email = "teste@7.com", Gabinete = "11", NumFuncionario = "11" },
                new Professor { Nome = "Teste 8", NumeroTelemovel = "961845265", Email = "teste@8.com", Gabinete = "12", NumFuncionario = "12" },
                new Professor { Nome = "Teste 9", NumeroTelemovel = "964587135", Email = "teste@9.com", Gabinete = "13", NumFuncionario = "13" },
                new Professor { Nome = "Teste 10", NumeroTelemovel = "965571234", Email = "teste@10.com", Gabinete = "14", NumFuncionario = "14" },
                new Professor { Nome = "Teste 11", NumeroTelemovel = "232111111", Email = "teste@11.com", Gabinete = "15", NumFuncionario = "15" },
                new Professor { Nome = "Teste 12", NumeroTelemovel = "232222222", Email = "teste@12.com", Gabinete = "16", NumFuncionario = "16" },
                new Professor { Nome = "Teste 13", NumeroTelemovel = "232333333", Email = "teste@13.com", Gabinete = "17", NumFuncionario = "17" },
                new Professor { Nome = "Teste 14", NumeroTelemovel = "232444444", Email = "teste@14.com", Gabinete = "18", NumFuncionario = "18" },
                new Professor { Nome = "Teste 15", NumeroTelemovel = "232555555", Email = "teste@15.com", Gabinete = "19", NumFuncionario = "19" },
                new Professor { Nome = "Teste 16", NumeroTelemovel = "232666666", Email = "teste@16.com", Gabinete = "20", NumFuncionario = "20" }
            );
            db.SaveChanges();
        }

        public static void PopulateFuncionario(FuncionarioDbContext db) {

            if (db.Funcionario.Any()) {
                return;
            }

            db.Funcionario.AddRange(
                new Funcionario { Nome = "Nil Silva", Contacto = "961123456", Email = "nil@silva.com", NumeroFuncionario="1"},
                new Funcionario { Nome = "Fernando Lopes", Contacto = "936654321", Email = "nando@lopes.pt", NumeroFuncionario = "2"},
                new Funcionario { Nome = "Nikita", Contacto = "232546123", Email = "niki@ta.com", NumeroFuncionario = "3"},
                new Funcionario { Nome = "Jacinta", Contacto = "912123456", Email = "jacinta@gmail.com", NumeroFuncionario = "4"},
                new Funcionario { Nome = "Teste 1", Contacto = "927895612", Email = "teste@1.com", NumeroFuncionario = "5"},
                new Funcionario { Nome = "Teste 2", Contacto = "921234568", Email = "teste@2.com", NumeroFuncionario = "6"},
                new Funcionario { Nome = "Teste 3", Contacto = "965874956", Email = "teste@3.com", NumeroFuncionario = "7"},
                new Funcionario { Nome = "Teste 4", Contacto = "935845612", Email = "teste@4.com", NumeroFuncionario = "8"},
                new Funcionario { Nome = "Teste 5", Contacto = "232548912", Email = "teste@5.com", NumeroFuncionario = "9"},
                new Funcionario { Nome = "Teste 6", Contacto = "232548796", Email = "teste@6.com", NumeroFuncionario = "10"},
                new Funcionario { Nome = "Teste 7", Contacto = "232158463", Email = "teste@7.com", NumeroFuncionario = "11"},
                new Funcionario { Nome = "Teste 8", Contacto = "961845265", Email = "teste@8.com", NumeroFuncionario = "12"},
                new Funcionario { Nome = "Teste 9", Contacto = "964587135", Email = "teste@9.com", NumeroFuncionario = "13"},
                new Funcionario { Nome = "Teste 10", Contacto = "965571234", Email = "teste@10.com", NumeroFuncionario = "14"},
                new Funcionario { Nome = "Teste 11", Contacto = "232111111", Email = "teste@11.com", NumeroFuncionario = "15"},
                new Funcionario { Nome = "Teste 12", Contacto = "232222222", Email = "teste@12.com", NumeroFuncionario = "16"},
                new Funcionario { Nome = "Teste 13", Contacto = "232333333", Email = "teste@13.com", NumeroFuncionario = "17"},
                new Funcionario { Nome = "Teste 14", Contacto = "232444444", Email = "teste@14.com", NumeroFuncionario = "18"},
                new Funcionario { Nome = "Teste 15", Contacto = "232555555", Email = "teste@15.com", NumeroFuncionario = "19"},
                new Funcionario { Nome = "Teste 16", Contacto = "232666666", Email = "teste@16.com", NumeroFuncionario = "20"}
            );
            db.SaveChanges();
        }

        public static async Task PopulateUsersAsync(UserManager<IdentityUser> userManager)
        {
            const string ADMIN_USERNAME = "admin@ipg.pt";
            const string ADMIN_PASSWORD = "Secret123$";

            IdentityUser user = await userManager.FindByNameAsync(ADMIN_USERNAME);

            if (user == null)
            {
                user = new IdentityUser
                {
                    UserName = ADMIN_USERNAME,
                    Email = ADMIN_USERNAME
                };

                await userManager.CreateAsync(user, ADMIN_PASSWORD);
            }

            if (!await userManager.IsInRoleAsync(user, ADMIN_ROLE))
            {
                await userManager.AddToRoleAsync(user, ADMIN_ROLE);
            }
        }

        public static async Task CreateRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync(ADMIN_ROLE))
            {
                await roleManager.CreateAsync(new IdentityRole(ADMIN_ROLE));
            }

            if (!await roleManager.RoleExistsAsync(BOSS_PROF_ROLE))
            {
                await roleManager.CreateAsync(new IdentityRole(BOSS_PROF_ROLE));
            }

            if (!await roleManager.RoleExistsAsync(BOSS_FUNC_ROLE))
            {
                await roleManager.CreateAsync(new IdentityRole(BOSS_FUNC_ROLE));
            }

            if (!await roleManager.RoleExistsAsync(PROF_ROLE))
            {
                await roleManager.CreateAsync(new IdentityRole(PROF_ROLE));
            }

            if (!await roleManager.RoleExistsAsync(FUNC_ROLE))
            {
                await roleManager.CreateAsync(new IdentityRole(FUNC_ROLE));
            }
        }
    }
}
