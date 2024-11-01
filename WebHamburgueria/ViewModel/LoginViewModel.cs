using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebHamburgueria.ViewModel
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe a senha.", AllowEmptyStrings = false)]
        public string Password { get; set; }
    }
}