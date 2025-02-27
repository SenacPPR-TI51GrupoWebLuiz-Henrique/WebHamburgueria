using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Resources;
using System.Linq;

namespace WebHamburgueria.ViewModels
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        [Display(Name = "CPF do Usuário")]
        public string CpfUsuario { get; set; }
        public string Total { get; set; }
        [Display(Name = "Data do Pedido")]
        public DateTime DataPedido { get; set; }
        public string Status { get; set; }
        [Display(Name = "Método de Pagamento")]
        public string MetPag { get; set; }

        // Lista de itens do pedido
        public List<ItensPedidoViewModel> Itens { get; set; } = new List<ItensPedidoViewModel>();
    }

}