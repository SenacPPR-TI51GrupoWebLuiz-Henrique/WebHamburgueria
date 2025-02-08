using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebHamburgueria.Models;
using WebHamburgueria.Viewmodel;

namespace WebHamburgueria.Controllers
{
    public class ProdutoController : Controller
    {
        private dbhamburgueriaEntities db = new dbhamburgueriaEntities();

        // GET: Produto
        public ActionResult Index()
        {
            return View(db.Produto.ToList());
        }

        // GET: Produto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produto.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Produto/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produtofoto)
        {
            if (ModelState.IsValid)
            {
                var produto = new Produto();

                if (produtofoto.ImageUpload != null)
                {
                    //lemos a imagem e a seguir os bytes armazenados
                    using (var binaryReader = new BinaryReader(produtofoto.ImageUpload.InputStream))
                        produto.Foto = binaryReader.ReadBytes(produtofoto.ImageUpload.ContentLength);
                }
                produto.Nome = produtofoto.Nome;
                produto.Preco = produtofoto.Preco;
                produto.Descricao = produtofoto.Descricao;
                produto.Ingredientes = produtofoto.Ingredientes;
                produto.Tipo = produtofoto.Tipo;

                db.Produto.Add(produto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produtofoto);
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produto.Find(id);
            ProdutoViewModel produtoFoto = new ProdutoViewModel();

            produtoFoto.Id = produto.Id;
            produtoFoto.Nome = produto.Nome;
            produtoFoto.Descricao = produto.Descricao;
            produtoFoto.Preco = produto.Preco;
            produtoFoto.Ingredientes = produto.Ingredientes;
            produtoFoto.Foto = produto.Foto;

            if (produtoFoto == null)
            {
                return HttpNotFound();
            }
            return View(produtoFoto);
        }

        // POST: Produto/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produtofoto)
        {
            var produto = db.Produto.Find(produtofoto.Id);

            produto.Nome = produtofoto.Nome;
            produto.Preco = produtofoto.Preco;
            produto.Descricao = produtofoto.Descricao;
            produto.Ingredientes = produtofoto.Ingredientes;

            if (produtofoto.ImageUpload != null)
            {
                //lemos a imagem e a seguir os bytes armazenados
                using (var binaryReader = new BinaryReader(produtofoto.ImageUpload.InputStream))
                    produto.Foto = binaryReader.ReadBytes(produtofoto.ImageUpload.ContentLength);
            }

            produto.Tipo = produtofoto.Tipo;

            if (ModelState.IsValid)
            {
                db.Entry(produto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(produtofoto);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Produto produto = db.Produto.Find(id);
            if (produto == null)
            {
                return HttpNotFound();
            }
            return View(produto);
        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Produto produto = db.Produto.Find(id);
            db.Produto.Remove(produto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
