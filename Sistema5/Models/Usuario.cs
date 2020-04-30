using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema5.Models
{
    public class Usuario
    {
        [Required]
        [Display(Name ="Nome do Usuário: ")]
        public string Nome { get; set; }
        [Required]
        [Display(Name ="Email do Usuário: ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
