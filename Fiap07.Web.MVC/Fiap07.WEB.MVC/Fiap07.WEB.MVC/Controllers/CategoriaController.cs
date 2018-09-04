﻿using Fiap07.WEB.MVC.Models;
using Fiap07.WEB.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.WEB.MVC.Controllers
{
    public class CategoriaController : Controller
    {

        private ImobiliariaContext _context = new ImobiliariaContext();

        // GET: Categoria
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            TempData["msg"] = "Categoria Cadastrada";
            return RedirectToAction("Cadastrar");
        }
    }
}