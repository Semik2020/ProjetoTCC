using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MeuWebSite.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Produto()
        {
            return View();
        }

        public ActionResult Fornecedor()
        {
            return View();
        }

        public ActionResult Estoque()
        {
            return View();
        }

        public ActionResult Cardapio()
        {
            return View();
        }
    }
}