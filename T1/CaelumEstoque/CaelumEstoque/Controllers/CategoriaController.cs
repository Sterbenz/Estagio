using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaelumEstoque.DAO;
using CaelumEstoque.Models;

namespace CaelumEstoque.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Index()
        {
            CategoriasDAO dao = new CategoriasDAO();
            IList<CategoriaDoProduto> categoria = dao.Lista();
            ViewBag.Categorias = categoria;
            return View();
        }

        public ActionResult Form()
        {    
            return View();
        }

        [HttpPost]
        public ActionResult Adiciona(CategoriaDoProduto categoria)
        {
            CategoriasDAO categoriasDAO = new CategoriasDAO();
            categoriasDAO.Adiciona(categoria);

            return RedirectToAction("Index", "Categoria");
        }
    }
}