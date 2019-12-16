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

        [Required(ErrorMessage = "Tem de inserir um nome")]
        [MaxLength(60, ErrorMessage = "O nome tem de ter menos de 60 carateres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Tem de inserir um numero de telemóvel/telefone")]
        [RegularExpression("(9[1236][0-9]{7})|(2[1-9][0-9]{7})")]
        [Display(Name = "Contacto")]
        [MaxLength(9)]
        public string NumeroTelemovel { get; set; }

        [Required(ErrorMessage = "Tem de inserir um email")]
        [EmailAddress]
        [MaxLength(60, ErrorMessage = "O nome tem de ter menos de 60 carateres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Tem de inserir um gabinete")]
        [MaxLength(3, ErrorMessage = "O nome tem de ter menos de 3 carateres")]
        public string Gabinete { get; set; }

        [Required(ErrorMessage = "Tem de inserir um numero de funcionário")]
        [MaxLength(9, ErrorMessage = "O nome tem de ter menos de 9 carateres")]
        public string NumFuncionario { get; set; }
    }
}
