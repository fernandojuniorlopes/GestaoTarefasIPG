using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models {
    public class Funcionario {

        [Required]
        public int FuncionarioId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "{0} deve ter entre {2} a {1} caracteres", MinimumLength = 5)]
        public string Nome { get; set; }
        [Required]
        [RegularExpression("(9[1236][0-9]{7})|(2[1-9][0-9]{7})")]
        public string Contacto { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Número de Funcionario")]
        [Range(0,10000, ErrorMessage = "{0} deve estar contido entre {1} e {2}.")]
        public string NumeroFuncionario { get; set; }
    }
}
