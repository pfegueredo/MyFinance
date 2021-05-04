using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyFinance.Models;
using Microsoft.AspNetCore.Http;

namespace MyFinance.Controllers
{
    public class ContaController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;

        public ContaController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            ContaModel objConta = new ContaModel(HttpContextAccessor); //Objeto do tipo Conta
            ViewBag.ListaConta = objConta.ListaConta();
            return View();
        }

        [HttpPost]
        public IActionResult CriarConta(ContaModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("Index");
            }
            return View(formulario);
        }

        [HttpGet]
        public IActionResult CriarConta()
        {

            return View();
        }


        
        public IActionResult ExcluirConta(int id)
        {
            ContaModel objConta = new ContaModel(HttpContextAccessor);
            objConta.Excluir(id);
            return RedirectToAction("Index");
        }

    }
}
