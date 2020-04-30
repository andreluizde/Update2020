using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema5.Models
{
    public class Cliente
    {
        [Required]
        [Display(Name = "Nome do Cliente: ")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "CPF/CNPJ: ")]
        public string CPF_CNPJ { get; set; }
        [Required]
        [Display(Name = "RG: ")]
        public string RG { get; set; }
        [Required]
        [Display(Name = "Estado Civil: ")]
        public string EstadoCivil { get; set; }
        [Required]
        [Display(Name = "Sexo: ")]
        public string Sexo { get; set; }
        [Required]
        [Display(Name = "Limite de Credito: ")]
        public string LimiteCredito { get; set; }
        [Required]
        [Display(Name = "Segmento: ")]
        public string Segmento { get; set; }
        [Required]
        [Display(Name = "Endereço: ")]
        public string Endereco { get; set; }
        [Required]
        [Display(Name = "Bairro: ")]
        public string Bairro { get; set; }
        [Required]
        [Display(Name = "Numero: ")]
        public string Numero { get; set; }
        [Required]
        [Display(Name = "CEP: ")]
        public string CEP { get; set; }
        [Required]
        [Display(Name = "Cidade: ")]
        public string Cidade { get; set; }
        [Required]
        [Display(Name = "Estado: ")]
        public string Estado { get; set; }
        [Required]
        [Display(Name = "Telefone: ")]
        public string Telefone { get; set; }
        [Required]
        [Display(Name = "E-mail: ")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Status: ")]
        public string _Status { get; set; }
    }
}
