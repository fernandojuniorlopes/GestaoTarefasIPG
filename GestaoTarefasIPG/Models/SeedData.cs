using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class SeedData
    {
        public static void Populate(ProfessorDbContext db)
        {
            if (db.Professor.Any())
            {
                return;
            }

            db.Professor.AddRange(
                new Professor { Nome = "Nil Silva", NumeroTelemovel = "961123456", Email = "nil@silva.com", Gabinete = "1" },
                new Professor { Nome = "Fernando Lopes", NumeroTelemovel = "936654321", Email = "nado@lopes.pt", Gabinete = "2" },
                new Professor { Nome = "Nikita", NumeroTelemovel = "232546123", Email = "niki@ta.com", Gabinete = "3" },
                new Professor { Nome = "Jacinta", NumeroTelemovel = "912123456", Email = "jacinta@gmail.com", Gabinete = "4" },
                new Professor { Nome = "Teste 1", NumeroTelemovel = "927895612", Email = "teste@1.com", Gabinete = "5" },
                new Professor { Nome = "Teste 2", NumeroTelemovel = "921234568", Email = "teste@2.com", Gabinete = "6" },
                new Professor { Nome = "Teste 3", NumeroTelemovel = "965874956", Email = "teste@3.com", Gabinete = "7" },
                new Professor { Nome = "Teste 4", NumeroTelemovel = "935845612", Email = "teste@4.com", Gabinete = "8" },
                new Professor { Nome = "Teste 5", NumeroTelemovel = "232548912", Email = "teste@5.com", Gabinete = "9" },
                new Professor { Nome = "Teste 6", NumeroTelemovel = "232548796", Email = "teste@6.com", Gabinete = "10" },
                new Professor { Nome = "Teste 7", NumeroTelemovel = "232158463", Email = "teste@7.com", Gabinete = "11" },
                new Professor { Nome = "Teste 8", NumeroTelemovel = "961845265", Email = "teste@8.com", Gabinete = "12" },
                new Professor { Nome = "Teste 9", NumeroTelemovel = "964587135", Email = "teste@9.com", Gabinete = "13" },
                new Professor { Nome = "Teste 10", NumeroTelemovel = "965571234", Email = "teste@10.com", Gabinete = "14" },
                new Professor { Nome = "Teste 11", NumeroTelemovel = "232111111", Email = "teste@11.com", Gabinete = "15" },
                new Professor { Nome = "Teste 12", NumeroTelemovel = "232222222", Email = "teste@12.com", Gabinete = "16" },
                new Professor { Nome = "Teste 13", NumeroTelemovel = "232333333", Email = "teste@13.com", Gabinete = "17" },
                new Professor { Nome = "Teste 14", NumeroTelemovel = "232444444", Email = "teste@14.com", Gabinete = "18" },
                new Professor { Nome = "Teste 15", NumeroTelemovel = "232555555", Email = "teste@15.com", Gabinete = "19" },
                new Professor { Nome = "Teste 16", NumeroTelemovel = "232666666", Email = "teste@16.com", Gabinete = "20" }
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
    }
}
