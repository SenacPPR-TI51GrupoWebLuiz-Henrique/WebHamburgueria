﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace WebHamburgueria.Models
{
    public class UsuarioController : Controller
    {
        private dbhamburgueriaEntities db = new dbhamburgueriaEntities();

        // GET: Usuario
        public ActionResult Index()
        {
            return View(db.Usuario.ToList());
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomeCompleto,NomeUsuario,Email,Cpf,Telefone,Nascimento,Genero,Endereco,Senha")] Usuario usuario)
        {
            if (usuario.Nascimento > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue || usuario.Nascimento < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue)
            {
                ModelState.AddModelError(nameof(usuario.Nascimento), "Data inválida.");
            }
            if (ModelState.IsValid)
            {
                usuario.Pontos = 0;
                if (usuario.NomeHost == null) usuario.NomeHost = "NaT";    // Host não é um terminal (Not a Terminal (NaT))
                db.Usuario.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomeCompleto,NomeUsuario,Email,Cpf,Telefone,Nascimento,Genero,Endereco,Pontos,Senha,Convidado,NomeHost")] Usuario usuario)
        {
            if (usuario.Nascimento > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue || usuario.Nascimento < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue)
            {
                ModelState.AddModelError(nameof(usuario.Nascimento), "Data inválida.");
            }
            if (ModelState.IsValid)
            {
                if (usuario.NomeHost == null) usuario.NomeHost = "NaT";    // Host não é um terminal (Not a Terminal (NaT))
                if (usuario.Pontos == null) usuario.Pontos = 0;

                db.Entry(usuario).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Usuario usuario = db.Usuario.Find(id);
            if (usuario == null)
            {
                return HttpNotFound();
            }
            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Usuario usuario = db.Usuario.Find(id);
            db.Usuario.Remove(usuario);
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
