﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebHamburgueria.Viewmodel
{
    public class ProdutoViewModel
    {
        [Display(Name = "ID")]
        public int Id { get; set; }
        public string Nome { get; set; }
        [Display(Name = "Preço")]
        [DataType(DataType.Currency)]
        public string Preco { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public string Ingredientes { get; set; }
        public byte[] Foto { get; set; }
        public string Tipo { get; set; }
        
        [DataType(DataType.Upload)]
        [Display(Name = "Imagem")]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}