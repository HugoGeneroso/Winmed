using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Winmed.Models
{
    public class Usuario
    {        
            public int ID { get; set; }

            [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "O Nome deve ser preenchido em um formato válido")]
            [Required]
            public string Nome{ get; set; }

            [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$", ErrorMessage = "O Sobrenome deve ser preenchido em um formato válido")]
            [Required]
            public string Sobrenome { get; set; }

            [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "O Email deve ser preenchido em um formato válido")]
            [Required]
            public string Email { get; set; }

            [RegularExpression(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})", ErrorMessage = "O CPF deve ser preenchido em um formato válido.")]
            [Required]
            public string CPF { get; set; }
    }
}