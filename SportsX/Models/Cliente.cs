using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SportsX.Models
{
    [Table("clientes")]
    public class Cliente
    {
        //Código cliente
        [Display(Name ="Código")]
        public int ClienteID { get; set; }
        //Tipo Cliente
        [Display(Name = "Tipo de Pessoa")]
        [Required(ErrorMessage = "Obrigatório pessoa física ou jurídica!")]       
        public TipoPessoa Tipo { get; set; }
        //Nome cliente
        [Display(Name = "Nome Cliente")]
        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        [MaxLength(100)]
        public string Nome { get; set; }
        //Razão Social
        [Display(Name = "Razão Social")]        
        [MaxLength(100)]
        public string Razao { get; set; }
        //CNPJ
        [Display(Name = "CNPJ/CPF")]
        [Required(ErrorMessage = "Obrigatório informar o CNPJ!")]
        public string Cnpj { get; set; }
        ////CPF
        //[Display(Name = "CPF")]
        //[Required(ErrorMessage = "Obrigatório informar o cpf!")]
        //[DisplayFormat(DataFormatString = "{0:###.###.###-##}", ApplyFormatInEditMode = true)]
        //public string Cpf { get; set; }
        //ENDEREÇO
        [Display(Name = "Endereço")]        
        public string Endereco { get; set; }
        //CEP
        [Display(Name = "Cód. Postal")]
        [DisplayFormat(DataFormatString = "{0:##-###-###}", ApplyFormatInEditMode = true)]
        public string Cep { get; set; }
        //E-mail
        [Required(ErrorMessage = "Obrigatório informar o e-mail!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        //Classificação
        [Required(ErrorMessage = "Obrigatório informar a classificação!")]
        [Display(Name = "Classificação")]
        public TipoClassificacao Classificacao { get; set; }  // Ativo - Inativo - Preferêncial
        //Telefone Fixo       
        [Display(Name = "Telefone Fixo")]
        public string TelFixo { get; set; }
        //Telefone 01       
        [Display(Name = "Telefone 01")]
        public string Fone01 { get; set; }
        //Telefone 02     
        [Display(Name = "Telefone 02")]
        public string Fone02 { get; set; }
        //Telefone 03    
        [Display(Name = "Telefone 03")]
        public string Fone03 { get; set; }
    }

    public enum TipoClassificacao
    {
        ATIVO,
        INATIVO, 
        PREFERÊNCIAL
    }

    public enum TipoPessoa
    {
        FÍSICA,
        JURÍDICA
    }
}

