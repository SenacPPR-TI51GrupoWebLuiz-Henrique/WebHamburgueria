using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHamburgueria.DTOs
{
	public class ProdutoDTO
	{
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}