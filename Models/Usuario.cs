//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebHamburgueria.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        [Display(Name = "Nome Completo")]
        public string NomeCompleto { get; set; }
        [Display(Name = "Nome de Usuário")]
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "Data de Nascimento")]
        public Nullable<System.DateTime> Nascimento { get; set; }
        [Display(Name = "Gênero")]
        public string Genero { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public Nullable<int> Pontos { get; set; }
        public string Senha { get; set; }
        public bool Convidado { get; set; }
        [Display(Name = "Nome do Host")]
        public string NomeHost { get; set; }
    }
}
