using Fiap07.WEB.MVC.Models;
using Fiap07.WEB.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.WEB.MVC.Controllers
{
    public class ImovelController : Controller
    {

        private ImobiliariaContext _context = new ImobiliariaContext();

        // GET: Imovel
        [HttpGet]
        public ActionResult Cadastar()
        {
            //Buscar por todas as categorias
            var lista = _context.Categorias.ToList();
            //Enviar para a tela a lista de categorias para o selectS
            ViewBag.categorias = new SelectList(lista, "CategoriaID", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Imovel imovel)
        {
            _context.Imoveis.Add(imovel);
            _context.SaveChanges();
            TempData["msg"] = "Categoria Cadastrada";
            return RedirectToAction("Cadastrar");
        }
    }
}