﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoTarefasIPG.Models {
    public class Funcionario {
        [Required]
        public int FuncionarioId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [RegularExpression("9[1236][0-9]{7}|2[1-9]{2}[0-9]{6}")]
        [Display(Name = "Numero de telemóvel")]
        public string NumeroTelemovel { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
