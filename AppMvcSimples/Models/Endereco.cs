﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcSimples.Models
{
    public class Endereco : Entity
    {
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(200, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(50, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(8, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(100, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(100, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} e obrigatorio")]
        [StringLength(50, ErrorMessage = "o campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Estado { get; set; }





        /*EF Relation*/
        public Fornecedor Fornecedor { get; set; }
    }
}
