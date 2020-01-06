using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models {
    public class FuncionariosViewModel {
        public IEnumerable<Funcionario> Funcionarios { get; set; }

        public int PaginaAtual { get; set; }

        public int TotalPaginas { get; set; }

        public int PrimeiraPagina { get; set; }

        public int UltimaPagina { get; set; }
        public string StringProcura { get; set; }
        public string Sort { get; set; }
        public string SearchBy { get; set; }
    }
}
