using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models
{
    public class Professor
    {
        [Required]
        public int ProfessorId { get; set; }

        [Required]
        [MaxLength(60, ErrorMessage = "O nome tem de ter menos de 60 carateres")]
        public string Nome { get; set; }

        [Required]
        [RegularExpression("(9[1236][0-9]{7})|(2[1-9][0-9]{7})")]
        [Display(Name = "Contacto")]
        [MaxLength(9)]
        public string NumeroTelemovel { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(60, ErrorMessage = "O nome tem de ter menos de 60 carateres")]
        public string Email { get; set; }

        [Required]
        public string Gabinete { get; set; }

        [Required]
        public string FuncionarioId { get; set; }
    }
}
