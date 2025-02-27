using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebHamburgueria.ViewModels
{
    public class ItensPedidoViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Id do Pedido")]
        public int IdPedido { get; set; }
        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; }
        [Display(Name = "Preço do Produto")]
        public string PrecoProduto { get; set; }
    }

}