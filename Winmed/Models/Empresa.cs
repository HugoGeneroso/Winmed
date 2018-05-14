using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Winmed.Models
{
    public class Empresa
    {
        public int ID { get; set; }
        
        [Required]
        public string RazaoSocial { get; set; }

        [Required]
        public string NomeFantasia { get; set; }
        
        [Required]
        public string Endereco { get; set; }

        [RegularExpression(@"^[0-9]*$", ErrorMessage = "O Numero deve ser preenchido em um formato válido")]
        [Required]
        public string Numero { get; set; }

        public string Complemento { get; set; }
        
        [Required]
        public string Bairro { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "O Email deve ser preenchido em um formato válido")]
        [Required]
        public string Email { get; set; }

        [Required]
        public string CNPJ { get; set; }
    }
}