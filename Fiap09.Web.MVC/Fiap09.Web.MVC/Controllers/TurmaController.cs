﻿using Fiap09.Web.MVC.Models;
using Fiap09.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap09.Web.MVC.Controllers
{
    public class TurmaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Turma turma)
        {
            _unit.TurmaRepository.Cadastrar(turma);
            _unit.Salvar();
            TempData["msg"] = "Cadastrado com sucesso!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}